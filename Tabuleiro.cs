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

        public Tabuleiro()
        {
            InitializeComponent();
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
                cmbPersonagem.Text = "";
                cmbSetor.Text = "";
            }
        }
        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }
    }
}
