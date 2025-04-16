using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferreirosDeYork.Gameplay
{
    public class Jogador
    {
        public string nomeJogador { get; set; }
        public string idJogador { get; set; }
        public string senhaJogador { get; set; }
        public string cartasNaMao { get; }

        public Jogador(string nomeJogador, string idJogador, string senhaJogador)
        {
            this.nomeJogador = nomeJogador;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.cartasNaMao = Jogo.ListarCartas(Convert.ToInt32(idJogador), senhaJogador);
        }


        private string EscolherPersonagemPromocao(Dictionary<string, List<string>> personagens)
        {
            string setorAtual;
            for (int setor = 1; setor <= 5; setor++)
            {
                setorAtual = setor.ToString();
                if (personagens.ContainsKey(setorAtual) && personagens[setorAtual].Count == 4)
                    personagens.Remove((setor - 1).ToString());
            }

            Random random = new Random();
            string setorEscolhidoAleatoriamente = personagens.Keys.ElementAt(random.Next(personagens.Count));
            int personagemEscolhidoAleatoriamente = random.Next(personagens[setorEscolhidoAleatoriamente].Count);
            return personagens[setorEscolhidoAleatoriamente][personagemEscolhidoAleatoriamente];
        }

        public void PromoverPersonagem(Dictionary<string, List<string>> personagens)
        {
            string personagemEscolhido = EscolherPersonagemPromocao(personagens);
            string resulatdoPromocao = Jogo.Promover(Convert.ToInt32(idJogador), senhaJogador, personagemEscolhido);

            //Tratando ERRO
            if (resulatdoPromocao.StartsWith("ERRO"))
                MessageBox.Show(resulatdoPromocao, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Votar(string voto) 
        {
            string resultadoVotacao = Jogo.Votar(Convert.ToInt16(idJogador), senhaJogador, voto); //Pega o resultado 

            //Tratando ERRO
            if (resultadoVotacao.StartsWith("ERRO"))
                MessageBox.Show(resultadoVotacao, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void PosicionarPersonagem(string listaDeCartasAbreviadas, Dictionary<string, List<string>> personagens)
        {
            Random random = new Random();

            HashSet<string> personagensNoTabuleiro = personagens.Values.SelectMany(p => p).ToHashSet();
            List<string> personagensDisponiveis = listaDeCartasAbreviadas
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

            string setorEscolhido = setoresDisponiveis[random.Next(setoresDisponiveis.Count)];

            //Chamada Função
            string resulatdoColocarPersonagem = Jogo.ColocarPersonagem(Convert.ToInt32(idJogador), senhaJogador, Convert.ToInt32(setorEscolhido), personagemEscolhido);

            //Tratando ERRO
            if (resulatdoColocarPersonagem.StartsWith("ERRO"))
                MessageBox.Show(resulatdoColocarPersonagem, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
