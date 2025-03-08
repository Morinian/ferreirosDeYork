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
        private TelaInicial menu; 

        public string idPartidaSelecionada { get; set; }
        public string nomePartidaSelecionada { get; set; }
        public string senhaPartidaSelecionada { get; set; }
        public string nomeJogadorSelecionado { get; set; }
        public string resultadoEntrarPartidaSelecionada { get; set; }


        public TelaLobby(TelaInicial menu)
        {
            InitializeComponent();
            this.menu = menu;
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
            //Atribuindo os valores do menu para o lobby
            lblPartidaId.Text = idPartidaSelecionada;
            lblNomePartida.Text = nomePartidaSelecionada;
            lblSenhaPartida.Text = senhaPartidaSelecionada;
            lblNomeJogadorPartida.Text = nomeJogadorSelecionado;

            string[] dadosJogador = resultadoEntrarPartidaSelecionada.Split(',');

            lblIdJogadorIdPartida.Text = dadosJogador[0];
            lblSenhaJogadorPartida.Text = dadosJogador[1];

            ListarJogadores(Convert.ToInt32(idPartidaSelecionada));
        }


        private void btnVoltarLobby_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void btnAtualizarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores(Convert.ToInt32(idPartidaSelecionada));
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {

        }
        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
