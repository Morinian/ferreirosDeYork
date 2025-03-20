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

        private string[] listaCartas = new string[]
        {
                "Adilson Konrad",
                "Beatriz Paiva",
                "Claro",
                "Douglas Baquiao",
                "Eduardo Takeo",
                "Guilherme Rey",
                "Heredia",
                "Karin",
                "Leonardo Takuno",
                "Mario Toledo",
                "Quintas",
                "Ranulfo",
                "Toshio"
        };
        //mapeamento de dicionario para minhas imagens
        private Dictionary<string, Image> imagemCartas;

        public Tabuleiro()
        {
            InitializeComponent();
            CarregarImagens();

        }
        private void CarregarImagens()
        {
            imagemCartas = new Dictionary<string, Image>();

            imagemCartas["Adilson Konrad"] = Properties.Resources.A_FP5Plebeu;
            imagemCartas["Beatriz Paiva"] = Properties.Resources.B_FP12Plebeu;
            imagemCartas["Claro"] = Properties.Resources.C_FP13Plebeu;
            imagemCartas["Douglas Baquiao"] = Properties.Resources.D_FP2Plebeu;
            imagemCartas["Eduardo Takeo"] = Properties.Resources.E_FP7Plebeu;
            imagemCartas["Guilherme Rey"] = Properties.Resources.G_FP1Plebeu;
            imagemCartas["Heredia"] = Properties.Resources.H_FP8Plebeu;
            imagemCartas["Karin"] = Properties.Resources.K_FP3Plebeu;
            imagemCartas["Leonardo Takuno"] = Properties.Resources.L_FP9Plebeu;
            imagemCartas["Mario Toledo"] = Properties.Resources.M_FP4Plebeu;
            imagemCartas["Quintas"] = Properties.Resources.Q_FP10Plebeu;
            imagemCartas["Ranulfo"] = Properties.Resources.R_FP6Plebeu;
            imagemCartas["Toshio"] = Properties.Resources.T_FP11Plebeu;

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
        private void btnVezJogador_Click(object sender, EventArgs e)
        {
            string resultadoVerificaVez = Jogo.VerificarVez(Convert.ToInt32(idPartidaSelecionada));

            //Resultado escrito mas ignorando a primeira linha ou sej deixando só o historico de jogadas
            string[] linhas = resultadoVerificaVez.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            lblVezJogador.Text = string.Join("\n", linhas.Skip(1));

            lblJogadorIdVez.Text = resultadoVerificaVez.Split(',')[0];

            //---JOGADORES---
            string retornoJogador = Jogo.ListarJogadores(Convert.ToInt32(idPartidaSelecionada));

            //Tratando o retorno das partidas
            retornoJogador = retornoJogador.Replace("\r", "");
            string[] listaJogadores = retornoJogador.Split('\n'); // separando os itens da lista pelo \n

            //conferindo os jogadores 
            for (int i = 0; i < listaJogadores.Length - 1; i++)
            {
               if(lblJogadorIdVez.Text == listaJogadores[i].Split(',')[0])
                {
                    lblJogadorNomeVez.Text = listaJogadores[i].Split(',')[1];
                }
            }
        }
        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            string personagemEscolhido = cmbPersonagem.Text.Substring(0,1); //Pegando o resultado do ComboBox primeira letra
            int setorEscolhido = int.Parse(cmbSetor.Text.Split(',')[0]); //Pegando o resultado do ComboBox pegando só o numero
            string resulatdoColocarPersonagem = Jogo.ColocarPersonagem(Convert.ToInt32(idJogadorSelecionado), senhaJogadorSelecionado,Convert.ToInt32(setorEscolhido), personagemEscolhido);

            //Tratando ERRO
            if (resulatdoColocarPersonagem.StartsWith("ERRO"))
                MessageBox.Show(resulatdoColocarPersonagem, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Limpando os ComboBoxes
                cmbPersonagem.Text = "";
                cmbSetor.Text = "";

                // Encontrando o nome completo do personagem pela primeira letra
                string personagemCompleto = listaCartas.FirstOrDefault(carta => carta.StartsWith(personagemEscolhido));
                if (personagemCompleto != null && imagemCartas.ContainsKey(personagemCompleto))
                {
                    // Criando um PictureBox para exibir a imagem do personagem no tabuleiro
                    PictureBox pbPersonagem = new PictureBox
                    {
                        Image = imagemCartas[personagemCompleto],
                        Location = CalcularPosicaoSetor(setorEscolhido), // Calcula a posição no tabuleiro
                        Size = new Size(50, 50), // Tamanho da imagem
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent
                    };

                    // Adicionando o PictureBox ao formulário
                    this.Controls.Add(pbPersonagem);
                }

            }
         }
        private Point CalcularPosicaoSetor(int setorEscolhido)
        {
            //AJUSTAR ISSO QUANDO IMPLEMENTAR O SETOR GRAFICAMENTE

            int baseX = 100; // Posição horizontal inicial
            int baseY = 100; // Posição vertical inicial
            int offsetX = 60; // Distância horizontal entre setores
            int offsetY = 60; // Distância vertical entre setores

            // Calculando posição com base no setor
            int col = (setorEscolhido - 1) % 3; // Exemplo: 3 colunas por linha
            int row = (setorEscolhido - 1) / 3;

            return new Point(baseX + col * offsetX, baseY + row * offsetY);
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
    }
}
