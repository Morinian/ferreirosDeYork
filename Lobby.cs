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

namespace ferreirosDeYork
{
    public partial class TelaLobby: Form
    {
        public string idPartidaSelecionada { get; set; }
        public string nomePartidaSelecionada { get; set; }


        public TelaLobby()
        {
            InitializeComponent();

        }

        public void ListarJogadores(int idPartida)
        {
            //---JOGADORES---
            string retornoJogador = Jogo.ListarJogadores(idPartida);

            //Tratando o retorno das partidas
            retornoJogador = retornoJogador.Replace("\r", "");
            string[] listaJogadores = retornoJogador.Split('\n'); // separando os itens da lista pelo \n

            //Limpando list box
            lstJogadores.Items.Clear();

            //Listando as partidas 
            for (int i = 0; i < listaJogadores.Length - 1; i++)
            {
                lstJogadores.Items.Add(listaJogadores[i]);
            }
        }

        public void AtualizarTela()
        {
            lblPartidaId.Text = idPartidaSelecionada;
            lblNomePartida.Text = nomePartidaSelecionada;
            ListarJogadores(Convert.ToInt32(idPartidaSelecionada));
        }
        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltarLobby_Click(object sender, EventArgs e)
        {
            TelaInicial menu = new TelaInicial();
            menu.Show();
            this.Close();
        }

        private void btnAtualizarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores(Convert.ToInt32(idPartidaSelecionada));
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

        }
    }
}
