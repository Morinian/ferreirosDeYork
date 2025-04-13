using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ferreirosDeYork
{
    public partial class Tabuleiro: Form
    {
        public string nomeJogadorSelecionado { get; set; }
        public string idJogadorSelecionado { get; set; }
        public string senhaJogadorSelecionado { get; set; }
        public string idPartidaSelecionada { get; set; }

        private List<PictureBox> personagensPosicao {get; set;}

        private string[] listaCartas = new string[]
        {
                "Adilson Konrad",
                "Beatriz Paiva",
                "Claro",
                "Douglas Baquiao",
                "Eduardo Takeo",
                "Guilherme Rey",
                "Heredia",
                "Kelly",
                "Leonardo Takuno",
                "Mario Toledo",
                "Quintas",
                "Ranulfo",
                "Toshio"
        };

        //mapeamento de dicionario para minhas imagens
        private Dictionary<string, Image> imagemCartas;
        Dictionary<string, List<string>> personagens = new Dictionary<string, List<string>>();
        public Tabuleiro()
        {
            InitializeComponent();
            CarregarImagens();
            lblVjogo.Text = ("V." + Jogo.versao);
            this.personagensPosicao = new List<PictureBox>();

            tmrVerificaVez.Enabled = true;
        }
        private void CarregarImagens()
        {
            this.imagemCartas = new Dictionary<string, Image>();

            this.imagemCartas["Adilson Konrad"] = Properties.Resources.A_FP5Plebeu;
            this.imagemCartas["Beatriz Paiva"] = Properties.Resources.B_FP12Plebeu;
            this.imagemCartas["Claro"] = Properties.Resources.C_FP13Plebeu;
            this.imagemCartas["Douglas Baquiao"] = Properties.Resources.D_FP2Plebeu;
            this.imagemCartas["Eduardo Takeo"] = Properties.Resources.E_FP7Plebeu;
            this.imagemCartas["Guilherme Rey"] = Properties.Resources.G_FP1Plebeu;
            this.imagemCartas["Heredia"] = Properties.Resources.H_FP8Plebeu;
            this.imagemCartas["Kelly"] = Properties.Resources.K_FP3Plebeu;
            this.imagemCartas["Leonardo Takuno"] = Properties.Resources.L_FP9Plebeu;
            this.imagemCartas["Mario Toledo"] = Properties.Resources.M_FP4Plebeu;
            this.imagemCartas["Quintas"] = Properties.Resources.Q_FP10Plebeu;
            this.imagemCartas["Ranulfo"] = Properties.Resources.R_FP6Plebeu;
            this.imagemCartas["Toshio"] = Properties.Resources.T_FP11Plebeu;

        }

        public void AtualizarTelaTabuleiro()
        {
            List<string> cartasNaMao = new List<string>();
            string resultadoCartas;

            //Atribuindo os valores do menu para o tabuleiro
            lblNomeJogadorPartida.Text = nomeJogadorSelecionado;
            lblIdJogadorIdPartida.Text = idJogadorSelecionado;
            lblSenhaJogadorPartida.Text = senhaJogadorSelecionado;

            resultadoCartas = Jogo.ListarCartas(Convert.ToInt32(idJogadorSelecionado), senhaJogadorSelecionado);

            //Comparando a primeira letra com a lista de nomes
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    if (listaCartas[j].Substring(0, 1) == resultadoCartas.Substring(i, 1))
                    {
                        cartasNaMao.Add(listaCartas[j]);
                    }
                }
            }

            //Mostrando os nomes
            lblCartaFavorita.Text = string.Join(Environment.NewLine, cartasNaMao);

            // Exibindo as cartas e imagens no formulário
            int yOffset = 199; // Posição inicial vertical
            foreach (var carta in cartasNaMao)
            {
                // Criando uma label para o texto da carta
                Label lblCarta = new Label
                {
                    Text = carta,
                    Location = new Point(50, yOffset),
                    AutoSize = true
                };

                // Criando um PictureBox para a imagem da carta
                PictureBox pbCarta = new PictureBox
                {
                    Image = imagemCartas.ContainsKey(carta) ? imagemCartas[carta] : null,
                    Location = new Point(10, yOffset),
                    Size = new Size(40, 40),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                // Adicionando os controles ao formulário
                this.Controls.Add(pbCarta);

                // Atualizando o deslocamento vertical
                yOffset += 40;
            }
        }

        private void organizarTabuleiro(string [] estadoAtualTabuleiro)
        {
            limparPosicionamentoPersonagens();

            personagens.Clear();
            string[] personagemDados;

            foreach (var personagem in estadoAtualTabuleiro)
            {
                personagemDados = personagem.Split(',');
                if (!personagens.ContainsKey(personagemDados[0]))
                {
                    personagens[personagemDados[0]] = new List<string>();
                }
                personagens[personagemDados[0]].Add(personagemDados[1]);
            }
            gerarPersonagensTabuleiro(personagens);
        }
        
        private void gerarPersonagensTabuleiro(Dictionary<string, List<string>> personagens)
        {
            //AJUSTAR ISSO QUANDO IMPLEMENTAR O SETOR GRAFICAMENTE

            int baseX = 400; // Posição horizontal inicial
            int baseY = 650; // Posição vertical inicial
            int offsetX = 130; // Distância horizontal entre os personagens
            int offsetY = 100; // Distância vertical entre setores

            foreach (var personagem in personagens)
            {
                for(int personagemPosicao = 0; personagemPosicao < personagem.Value.Count; personagemPosicao++)
                {
                    gerarImgPersonagemPosicionada(personagem.Value[personagemPosicao],
                        new Point(
                                baseX + (personagemPosicao * offsetX),
                                baseY - (Convert.ToInt32(personagem.Key) * offsetY)
                        )
                    );
                }
            } 
        }

        private void limparPosicionamentoPersonagens()
        {
            foreach (PictureBox perssonagem in this.personagensPosicao)
            {
                this.Controls.Remove(perssonagem);
                perssonagem.Dispose();
            }
        }

        private void gerarImgPersonagemPosicionada(string personagemNome, Point posicao)
        {
            // Encontrando o nome completo do personagem pela primeira letra
            string personagemCompleto = listaCartas.FirstOrDefault(carta => carta.StartsWith(personagemNome));
            if (personagemCompleto != null && imagemCartas.ContainsKey(personagemCompleto))
            {
                // Criando um PictureBox para exibir a imagem do personagem no tabuleiro
                PictureBox pbPersonagem = new PictureBox
                {
                    Image = imagemCartas[personagemCompleto],
                    Location = posicao, // Calcula a posição no tabuleiro
                    Size = new Size(80, 80), // Tamanho da imagem
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };

                //Mapeia os containers
                personagensPosicao.Add(pbPersonagem);

                // Adicionando o PictureBox ao formulário
                this.Controls.Add(pbPersonagem);

                pbPersonagem.BringToFront();
                pbPersonagem.BackColor = Color.Transparent;
            }
        }
        private void btnPromover_Click(object sender, EventArgs e)
        {
            string personagemEscolhido = cmbPersonagem.Text.Substring(0, 1); //Pegando o resultado do ComboBox primeira letra
            string resulatdoPromocao = Jogo.Promover(Convert.ToInt32(idJogadorSelecionado), senhaJogadorSelecionado, personagemEscolhido);

            //Tratando ERRO
            if (resulatdoPromocao.StartsWith("ERRO"))
                MessageBox.Show(resulatdoPromocao, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Limpando o ComboBox
                cmbPersonagem.Text = "";
            }
        }
        private void btnVotar_Click(object sender, EventArgs e)
        {
            //Pega o primeira letra
            string votar = cmbVotacao.Text.Substring(0, 1);
            string resultadoVotacao = Jogo.Votar(Convert.ToInt16(idJogadorSelecionado), senhaJogadorSelecionado, votar); //Pega o resultado 

            //Tratando ERRO
            if (resultadoVotacao.StartsWith("ERRO"))
                MessageBox.Show(resultadoVotacao, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Limpando o ComboBox
                cmbVotacao.Text = "";
            }
        }
        private void VerificarVez()
        {
            string resultadoVerificaVez = Jogo.VerificarVez(Convert.ToInt32(idPartidaSelecionada));

            //Resultado escrito mas ignorando a primeira linha ou seja deixando só o historico de jogadas
            string[] linhas = resultadoVerificaVez.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            lblVezJogador.Text = string.Join("\n", linhas.Skip(1));
            organizarTabuleiro(linhas.Skip(1).ToArray());

            lblJogadorIdVez.Text = resultadoVerificaVez.Split(',')[0];
            lblStatusJogo.Text = resultadoVerificaVez.Split(',')[3].Trim().ToUpper()[0].ToString();

            //---JOGADORES---
            string retornoJogador = Jogo.ListarJogadores(Convert.ToInt32(idPartidaSelecionada));

            //Tratando o retorno das partidas
            retornoJogador = retornoJogador.Replace("\r", "");
            string[] listaJogadores = retornoJogador.Split('\n'); // separando os itens da lista pelo \n

            //conferindo os jogadores 
            for (int i = 0; i < listaJogadores.Length - 1; i++)
            {
                if (lblJogadorIdVez.Text == listaJogadores[i].Split(',')[0])
                {
                    lblJogadorNomeVez.Text = listaJogadores[i].Split(',')[1];
                }
            }
        }

        private void PosicionarPersonagem()
        {
            Random random = new Random();

            //Pegando personagem
            string todosPersonagens = "ABCEGHKMQRT";

            HashSet<string> personagensNoTabuleiro = personagens.Values.SelectMany(p => p).ToHashSet();
            List<string> personagensDisponiveis = todosPersonagens
                .Select(c => c.ToString())
                .Where(p => !personagensNoTabuleiro.Contains(p))
                .ToList();

            string personagemEscolhido = personagensDisponiveis[random.Next(personagensDisponiveis.Count)];

            //Pegando o setor
            List<string> setoresDisponiveis = new List<string>();

            for (int i = 1; i < 5; i++)
            {
                string setor = i.ToString();

                // Se o setor não existe ou tem menos de 4 personagens, ele está disponível
                if (!personagens.ContainsKey(setor) || personagens[setor].Count < 4)
                {
                    setoresDisponiveis.Add(setor);
                }
            }
            label9.Text = string.Join(Environment.NewLine, personagensDisponiveis);

            string setorEscolhido = setoresDisponiveis[random.Next(setoresDisponiveis.Count)];

            //Chamada Função
            string resulatdoColocarPersonagem = Jogo.ColocarPersonagem(Convert.ToInt32(idJogadorSelecionado), senhaJogadorSelecionado, Convert.ToInt32(setorEscolhido), personagemEscolhido);

            //Tratando ERRO
            if (resulatdoColocarPersonagem.StartsWith("ERRO"))
                MessageBox.Show(resulatdoColocarPersonagem, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void tmrVerificaVez_Tick(object sender, EventArgs e)
        {
            //Inicio
            tmrVerificaVez.Enabled = false;
            
            //Jogador 
            VerificarVez();

            if( lblJogadorIdVez.Text == idJogadorSelecionado)
            {

                if (lblStatusJogo.Text == "S")
                {
                    PosicionarPersonagem();
                }
                else if(lblStatusJogo.Text == "P")
                {
      
                }
                
            }

            //Fim
            tmrVerificaVez.Enabled = true;
        }
        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void cmbPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NomeDOGrupo_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
