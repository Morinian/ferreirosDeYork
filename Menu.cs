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
    public partial class TelaInicial: Form
    {
        private string nomeGrupo = "Ferreiros de York";

        //Valores que vou passar para o lobby
        private string idPartidaSelecionada;
        private string nomePartidaSelecionada;
        private string senhaPartidaSelecionada;
        private string nomeJogadorSelecionado;
        private string resultadoEntrarPartidaSelecionada;
        public TelaInicial()
        {
            InitializeComponent();
            txtNomeGrupoCriarPartida.Text = nomeGrupo;
            lblNomeGrupo.Text = nomeGrupo;
            lblVersaoJogo.Text = ("V."+Jogo.versao);
        }

        private void btnListarPartida_Click(object sender, EventArgs e)
        {
            //Limpando list box
            lstPartidas.Items.Clear();

            //Pegando o valor das partidas
            string retornoPartida = Jogo.ListarPartidas("T");

            //Tratando o retorno das partidas
            retornoPartida = retornoPartida.Replace("\r", ""); 
            string[] listaPartida = retornoPartida.Split('\n'); // separando os itens da lista pelo \n

            //Listando as partidas 
            for(int i = 0; i < listaPartida.Length - 1; i++)
            {
                lstPartidas.Items.Add(listaPartida[i]);
            }
        }

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pegando valor da lst que esta selecionada
            string itemPartida = lstPartidas.SelectedItem.ToString();
            string[] dadosPartida = itemPartida.Split(','); // separando os itens pela ,

            int idPartida = Convert.ToInt32(dadosPartida[0]);
            string nomePartida = dadosPartida[1];
            string dataPartida = dadosPartida[2];

            //Colando os valores na Label
            lblPartidaId.Text = idPartida.ToString();
            lblNomePartida.Text = nomePartida;
            lblDataPartida.Text = dataPartida;

            //---JOGADORES---
            string retornoJogador = Jogo.ListarJogadores(idPartida);

            //Tratando o retorno das partidas
            retornoJogador = retornoJogador.Replace("\r", "");
            string[] listaJogadores = retornoJogador.Split('\n'); // separando os itens da lista pelo \n

            //Limpando list box
            lstJogadores.Items.Clear();

            //Listando os jogadores 
            for (int i = 0; i < listaJogadores.Length - 1; i++)
            {
                lstJogadores.Items.Add(listaJogadores[i]);
            }

        }
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            //Passando os parametros para criar a partida
            string resulatdoCriacao = Jogo.CriarPartida(
                txtNomeCriarPartida.Text,
                txtSenhaCriarPartida.Text,
                txtNomeGrupoCriarPartida.Text
            );

            //Tratando ERRO
            if (resulatdoCriacao.StartsWith("ERRO"))
                MessageBox.Show(resulatdoCriacao, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                txtNomeCriarPartida.Text = "";
                txtSenhaCriarPartida.Text = "";
            }
        }
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            //precisamos fazer também se o jogador existir entrar na partida com os dados dele

            //Mandando os parametros para entrar na partida
            string resultadoEntrar = Jogo.Entrar(
                Convert.ToInt32(lblPartidaId.Text),
                txtNomeJogador.Text,
                txtSenhaEntrarPartida.Text
            );

            if (resultadoEntrar.StartsWith("ERRO"))
            {
                MessageBox.Show("❗" + resultadoEntrar + "❗", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide(); //esconder menu
                TelaLobby lobby = new TelaLobby(this); //passando o menu como referencia no lobby para conseguir voltar para cá

                //Valores para o Lobby
                lobby.idPartidaSelecionada = lblPartidaId.Text;
                lobby.nomePartidaSelecionada = lblNomePartida.Text;
                lobby.nomeJogadorSelecionado = txtNomeJogador.Text;
                lobby.senhaPartidaSelecionada = txtSenhaEntrarPartida.Text;
                lobby.resultadoEntrarPartidaSelecionada = resultadoEntrar;

                //chamando função que vai atualizar os valores na tela
                lobby.AtualizarTelaLobby();
                lobby.ShowDialog(); //iniciar lobby
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fechar aplicação
            this.Close();
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void lblNomePartida_Click(object sender, EventArgs e)
        {

        }

    }
}
