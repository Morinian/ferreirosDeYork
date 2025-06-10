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
using ferreirosDeYork.Gameplay;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ferreirosDeYork
{
    public partial class Tabuleiro: Form
    {
        public Jogador jogador { get; set; }
        public string idPartidaSelecionada { get; set; }

        private Dictionary<string, List<PictureBox>> estruturaTabuleiro { get; set; }

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

        private const string listaDeCartasAbreviadas = "ABCEGHKLMQRT";

        //mapeamento de dicionario para minhas imagens
        private Dictionary<string, Image> imagemCartas;
        Dictionary<string, List<string>> personagens = new Dictionary<string, List<string>>();
        public Tabuleiro(Jogador jogador)
        {
            InitializeComponent();
            CarregarImagens();
            lblVjogo.Text = ("V." + Jogo.versao);
            this.jogador = jogador;
            tmrVerificaVez.Enabled = true;
            EstruturarTabuleiro();
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

        public void AtualizarDadosTelaJogo()
        {
            List<string> cartasNaMao = new List<string>();

            //Atribuindo os valores do menu para o tabuleiro
            lblNomeJogadorPartida.Text = jogador.nomeJogador;
            lblIdJogadorIdPartida.Text = jogador.idJogador;
            lblSenhaJogadorPartida.Text = jogador.senhaJogador;

            //Comparando a primeira letra com a lista de nomes
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    if (listaCartas[j].Substring(0, 1) == jogador.cartasNaMao.Substring(i, 1))
                    {
                        cartasNaMao.Add(listaCartas[j]);
                    }
                }
            }

            //Mostrando os nomes
            lblCartaFavorita.Text = string.Join(Environment.NewLine + Environment.NewLine, cartasNaMao);

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

        private void EstruturarTabuleiro()
        {
            this.estruturaTabuleiro = new Dictionary<string, List<PictureBox>>();

            int baseX = 400; // Posição horizontal inicial
            int baseY = 650; // Posição vertical inicial
            int offsetX = 130; // Distância horizontal entre os personagens
            int offsetY = 100; // Distância vertical entre setores

            PictureBox posicaoSetor;
            Point coordenadasPosicaoSetor;
            string setorKey;
            for (int setor = 0; setor <= 6; setor++)
            {
                setorKey = setor == 6 ? "10" : setor.ToString(); //Considera a key do Rei

                //Cria o setor na estrutura do tabuleiro
                this.estruturaTabuleiro.Add(setorKey, new List<PictureBox>());

                for (int personagemPosicao = 0; personagemPosicao <= 4; personagemPosicao++) {

                    // Calcula a posição no tabuleiro
                    coordenadasPosicaoSetor = new Point(
                            setor == 6 ? 590 //Posição X do Rei
                            : baseX + (personagemPosicao * offsetX),
                            setor == 6 ? 80 //Posição Y do Rei
                            : baseY - (Convert.ToInt32(setor) * offsetY)
                    );

                    posicaoSetor = new PictureBox
                    {
                        Location = coordenadasPosicaoSetor,
                        Size = new Size(80, 80), // Tamanho da imagem
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent
                    };

                    //Adiciona uma posição de personagem no setor
                    this.estruturaTabuleiro[setorKey].Add(posicaoSetor);
                    // Adicionando o PictureBox ao formulário
                    this.Controls.Add(posicaoSetor);

                    //Adiciona apenas 1 PictureBox para o rei
                    if (setor == 6)
                    {
                        posicaoSetor.BringToFront();
                        break;
                    }
                        
                }
            }
        }

        private void organizarTabuleiro(string [] estadoAtualTabuleiro)
        {
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
            gerarPersonagensTabuleiro();
        }
        
        private void gerarPersonagensTabuleiro()
        {
            LimparImagensTabuleiro();
            string personagemNomeCompleto;
            string personagemNomeAbreviado;
            foreach (var setor in personagens)
            {
                for(int personagemPosicao = 0; personagemPosicao < setor.Value.Count; personagemPosicao++)
                {
                    personagemNomeAbreviado = setor.Value[personagemPosicao];
                    // Encontrando o nome completo do personagem pela primeira letra
                    personagemNomeCompleto = listaCartas.FirstOrDefault(carta => carta.StartsWith(personagemNomeAbreviado));
                    if (personagemNomeCompleto != null && this.imagemCartas.ContainsKey(personagemNomeCompleto))
                    {
                        this.estruturaTabuleiro[setor.Key][personagemPosicao].Image = this.imagemCartas[personagemNomeCompleto];
                    }
                }
            } 
        }

        private void LimparImagensTabuleiro()
        {
            foreach(List<PictureBox> setor in this.estruturaTabuleiro.Values)
            {
                foreach (PictureBox personagemPosicao in setor)
                {
                    personagemPosicao.Image = null;
                }
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

        private void verificarPlacar()
        {
            string retornoJogador = Jogo.ListarJogadores(Convert.ToInt32(idPartidaSelecionada));

            // Tratando o retorno das partidas
            retornoJogador = retornoJogador.Replace("\r", "");
            string[] listaJogadores = retornoJogador.Split('\n');

            List<string> placaresOponentes = new List<string>();
            string meuplacar = "";

            listaJogadores = listaJogadores.Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();

            foreach (string jogador in listaJogadores)
            {
                string[] partes = jogador.Split(',');

                string idJogador = partes[0];
                string placar = partes[partes.Length - 1];

                if (idJogador == lblIdJogadorIdPartida.Text)
                    meuplacar = placar;
                else
                    placaresOponentes.Add(placar);
            }

            List<string> placares = new List<string>
            {
                meuplacar
            };
            placares.AddRange(placaresOponentes);

            lblPlacar.Text = string.Join(" x ", placares);

        }

        private void tmrVerificaVez_Tick(object sender, EventArgs e)
        {
            //Inicio
            tmrVerificaVez.Enabled = false;
            
            //Jogador 
            VerificarVez();

            if(lblJogadorIdVez.Text == jogador.idJogador)
            {

                if (lblStatusJogo.Text == "S")
                {
                    verificarPlacar();
                    jogador.PosicionarPersonagem(listaDeCartasAbreviadas, personagens);
                }
                else if(lblStatusJogo.Text == "P")
                {
                    jogador.PromoverPersonagem(personagens);
                }
                else if(lblStatusJogo.Text == "V")
                {
                    jogador.Votar(personagens);
                }
            } else if (lblStatusJogo.Text == "E")
            {
                verificarPlacar();
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
