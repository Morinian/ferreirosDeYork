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

        private void Tabuleiro_Load(object sender, EventArgs e)
        {

        }
    }
}
