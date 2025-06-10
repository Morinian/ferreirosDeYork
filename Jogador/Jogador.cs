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

        public bool tenhoVotosNao { get; set; }

        public Jogador(string nomeJogador, string idJogador, string senhaJogador)
        {
            this.nomeJogador = nomeJogador;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
            this.cartasNaMao = Jogo.ListarCartas(Convert.ToInt32(idJogador), senhaJogador);
            this.tenhoVotosNao = true;
        }


        private string EscolherPersonagemPromocao(Dictionary<string, List<string>> personagens)
        {
            //Adiciona em uma lista todos os setores que não permitem promoção. 
            //Só ocorre se o setor acima estiver cheio (4 personagens)
            string setorAtual;
            List<string> setoresPromoImpossivel = new List<string>();
            for (int setor = 1; setor <= 5; setor++)
            {
                setorAtual = setor.ToString();
                if (personagens.ContainsKey(setorAtual) && personagens[setorAtual].Count == 4)
                    setoresPromoImpossivel.Add((setor - 1).ToString());
            }

            Random random = new Random();

            //Lista todos os personagens Não favoritos no setor 4 e promove 1 aleatóriamente, se possivel
            if(!setoresPromoImpossivel.Contains("4") && personagens.ContainsKey("4"))
            {
                List<string> listNaoFavDignatarios = personagens["4"]
                .Select(nobre => nobre.ToString())
                .Where(nobre => !this.cartasNaMao.Contains(nobre))
                .ToList();
                if (listNaoFavDignatarios.Count > 0)
                    return listNaoFavDignatarios[random.Next(listNaoFavDignatarios.Count)];
            }
            //Lista todos os personagens Não favoritos no setor 5 e promove 1 aleatóriamente (para rei), se possivel
            if (!setoresPromoImpossivel.Contains("5") && personagens.ContainsKey("5"))
            {
                List<string> listNaoFavNobres = personagens["5"]
                .Select(nobre => nobre.ToString())
                .Where(nobre => !this.cartasNaMao.Contains(nobre))
                .ToList();
                if (listNaoFavNobres.Count > 0)
                    return listNaoFavNobres[random.Next(listNaoFavNobres.Count)];
            }
            //Lista todos os personagens favoritos no setor 4 e promove 1 aleatóriamente, se for
            //possivel e caso existam 2 ou mais personages favoritos no setor.
            if (!setoresPromoImpossivel.Contains("4") && personagens.ContainsKey("4") && personagens["4"].Count >= 2) 
            {
                List<string> listFavDignatarios = personagens["4"]
                .Select(nobre => nobre.ToString())
                .Where(nobre => this.cartasNaMao.Contains(nobre))
                .ToList();
                return listFavDignatarios[random.Next(listFavDignatarios.Count)];
            }

            foreach (string setor in setoresPromoImpossivel)
                personagens.Remove(setor);

            //Retorna uma key não removida do Dictionary, de maneira aleatoria, baseado na quantidade de keys restantes.
            string setorEscolhidoAleatoriamente = personagens.Keys.ElementAt(random.Next(personagens.Count));
            //Escolhe um index aleatorio da key, representando um personagem do setor.
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

        //Se "tenhoVotosNao" for false, o voto sempre será sim. Se for true, o voto é randomizado
        public void Votar(Dictionary<string, List<string>> personagens) 
        {
            string voto = "S";
            if (this.tenhoVotosNao)
            {
                if (personagens.ContainsKey("10"))
                {
                    //Voto é igual a Não, se o candidato não for favorito
                    if (!this.cartasNaMao.Contains(personagens["10"].First()))
                        voto = "N";
                }
            }

            /*Executa "Votar" até o voto passar, ou até um erro não relacionado com o uso
             * acima do limite de vetos ocorrer*/
            while (true)
            {
                string resultadoVotacao = Jogo.Votar(Convert.ToInt16(idJogador), senhaJogador, voto); //Pega o resultado 

                //Tratando ERRO
                if (resultadoVotacao.StartsWith("ERRO"))
                {
                    if (this.tenhoVotosNao)
                    {
                        this.tenhoVotosNao = false;
                        voto = "S";
                    }
                    else
                    {
                        MessageBox.Show(resultadoVotacao, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                        
                }
                else break;
            }

        }

        public void PosicionarPersonagem(string listaDeCartasAbreviadas, Dictionary<string, List<string>> personagens)
        {
            Random random = new Random();

            //Cria uma Lista apenas com os personagens que não foram colocadas no tabuleiro
            HashSet<string> personagensNoTabuleiro = personagens.Values.SelectMany(p => p).ToHashSet();
            List<string> personagensDisponiveis = listaDeCartasAbreviadas
                .Select(c => c.ToString())
                .Where(p => !personagensNoTabuleiro.Contains(p))
                .ToList();

            //Cria uma Lista apenas com os personagens favorito disponiveis para setagem
            string personagemEscolhido;
            List<string> favoritosNaoPosicionados = personagensDisponiveis
                .Select(disponivel => disponivel.ToString())
                .Where(disponivel => this.cartasNaMao.Contains(disponivel))
                .ToList();

            //Pegando os setores Disponiveis
            string setorEscolhido;
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

            if (favoritosNaoPosicionados.Count > 0)
            {
                personagemEscolhido = favoritosNaoPosicionados[random.Next(favoritosNaoPosicionados.Count)];
                //Pegando o maior valor do setor dispovivel, conseguimos manter os favoritos em setores altos
                setorEscolhido =  setoresDisponiveis.Select(int.Parse).Max().ToString();
            }
            else
            {
                personagemEscolhido = personagensDisponiveis[random.Next(personagensDisponiveis.Count)];
                setorEscolhido = setoresDisponiveis[random.Next(setoresDisponiveis.Count)];
            }

            //Chamada Função
            string resulatdoColocarPersonagem = Jogo.ColocarPersonagem(Convert.ToInt32(idJogador), senhaJogador, Convert.ToInt32(setorEscolhido), personagemEscolhido);

            //Tratando ERRO
            if (resulatdoColocarPersonagem.StartsWith("ERRO"))
                MessageBox.Show(resulatdoColocarPersonagem, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
