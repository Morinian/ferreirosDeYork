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
        private string nomeGrupo = "Ferreiros de York";
        private TelaInicial menu; 

        //Informações que são do Menu
        public string idPartidaSelecionada { get; set; }
        public string nomePartidaSelecionada { get; set; }
        public string senhaPartidaSelecionada { get; set; }
        public string nomeJogadorSelecionado { get; set; }
        public string resultadoEntrarPartidaSelecionada { get; set; }


        public TelaLobby(TelaInicial menu)
        {
            InitializeComponent();
            this.menu = menu;

            lblNomeGrupo.Text = nomeGrupo;
            lblVersaoJogo.Text = ("V." + Jogo.versao);


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

        public void AtualizarTelaLobby()
        {
            //Atribuindo os valores do menu para o lobby
            lblPartidaId.Text = idPartidaSelecionada;
            lblNomePartida.Text = nomePartidaSelecionada;
            lblSenhaPartida.Text = senhaPartidaSelecionada;
            lblNomeJogadorPartida.Text = nomeJogadorSelecionado;

            //pergando o id e a senha do jogador que vem em uma string unica
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
            Tabuleiro tabuleiro = new Tabuleiro();

            // Pegando o valor das partidas
            string estadoPartida = "";
            string retornoPartida = Jogo.ListarPartidas("T");

            // Tratando o retorno das partidas
            retornoPartida = retornoPartida.Replace("\r", "");
            string[] listaPartida = retornoPartida.Split('\n'); // separando os itens da lista pelo \n

            // pegando apenas o estado da partida
            for (int i = 0; i < listaPartida.Length - 1; i++)
            {
                string[] dadosPartida = listaPartida[i].Split(',');

                if (dadosPartida[0] == idPartidaSelecionada)
                {
                    estadoPartida = dadosPartida[3]; // Pegando o estado da partida
                }
            }

            //Verificando se ja foi iniciado o jogo
            // se igual A então inicie 
            // se igual a J então entre 
            if (estadoPartida == "A")
            {
                string resultatoJogoInciar = Jogo.Iniciar(Convert.ToInt32(lblIdJogadorIdPartida.Text), lblSenhaJogadorPartida.Text);

                if (resultatoJogoInciar.StartsWith("ERRO"))
                {
                    MessageBox.Show("❗"+ resultatoJogoInciar + "❗", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Valores para o tabuleiro
                    tabuleiro.nomeJogadorSelecionado = this.nomeJogadorSelecionado;
                    tabuleiro.idJogadorSelecionado = lblIdJogadorIdPartida.Text;
                    tabuleiro.senhaJogadorSelecionado = lblSenhaJogadorPartida.Text;
                    tabuleiro.idPartidaSelecionada = lblPartidaId.Text;

                    //chamando função que vai atualizar os valores na tela
                    tabuleiro.AtualizarTelaTabuleiro();

                    tabuleiro.Show(); //iniciar lobby
                    this.Close();
                }
            }
            else if (estadoPartida == "J")
            {
                //Valores para o tabuleiro
                tabuleiro.nomeJogadorSelecionado = this.nomeJogadorSelecionado;
                tabuleiro.idJogadorSelecionado = lblIdJogadorIdPartida.Text;
                tabuleiro.senhaJogadorSelecionado = lblSenhaJogadorPartida.Text;
                tabuleiro.idPartidaSelecionada = lblPartidaId.Text;

                //chamando função que vai atualizar os valores na tela
                tabuleiro.AtualizarTelaTabuleiro();

                tabuleiro.Show(); //iniciar lobby
                this.Close();
            }

        }
        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelaLobby_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblPARTIDA_Click(object sender, EventArgs e)
        {

        }

        private void lblPartidaId_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLobby_Load_1(object sender, EventArgs e)
        {

        }
    }
}
