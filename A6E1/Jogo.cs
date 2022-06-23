namespace A6E1
{
    public class Jogo
    {
        private string[,] Tabuleiro = new string[3, 3];
        private int Rodada = 0;

        private string JogadorX;
        private string JogadorO;

        // private bool Turno = true;
        public Jogo()
        {
            JogadorX = String.Empty;
            JogadorO = String.Empty;

            Iniciar();
        }

        private void Iniciar()
        {
            Console.WriteLine("Jogo da Velha\n");
            Desenhar();
        }

        private void Desenhar()
        {
            //Preencher();

            Console.Clear();

            Console.WriteLine($"Jogador X: {JogadorX} - Jogador O: {JogadorO}\n");

            Console.WriteLine($"{Tabuleiro[2, 0]} | {Tabuleiro[2, 1]} | {Tabuleiro[2, 2]}");
            Console.WriteLine("-------------");
            Console.WriteLine($"{Tabuleiro[1, 0]} | {Tabuleiro[1, 1]} | {Tabuleiro[1, 2]}");
            Console.WriteLine("-------------");
            Console.WriteLine($"{Tabuleiro[0, 0]} | {Tabuleiro[0, 1]} | {Tabuleiro[0, 2]}");

            Jogada();
        }

        private void Preencher()
        {
            Tabuleiro[0, 0] = "7";
            Tabuleiro[0, 1] = "8";
            Tabuleiro[0, 2] = "9";

            Tabuleiro[1, 0] = "4";
            Tabuleiro[1, 1] = "5";
            Tabuleiro[1, 2] = "6";

            Tabuleiro[2, 0] = "1";
            Tabuleiro[2, 1] = "2";
            Tabuleiro[2, 2] = "3";

            int Contador = 0;

            for (int Linha = 0; Linha < 3; Linha++)
            {
                for (int Coluna = 0; Coluna < 3; Coluna++)
                {
                    Rodada++;
                    Tabuleiro[Linha, Coluna] = Convert.ToString(Contador);

                }

            }
        }

        private bool Vencedor()
        {
            return true;
        }

        private void Jogada()
        {
            bool Limite = Rodada > 0;
            bool Fim = Vencedor() || Limite;

            while(Fim)
            {
                Console.WriteLine("Escolha a posição que deseja jogar:");
                Console.WriteLine("> ");
                bool ValidarEntrada = int.TryParse(Console.ReadLine(), out int EscolhaDoJogador;

                if(ValidarEntrada)
                {
                    switch (EscolhaDoJogador)
                    {
                        case 0:
                            break;

                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            break;

                        case 7:
                            break;

                        case 8:
                            break;

                        case 9:
                            break;

                        default:
                            break;

                    }
                }
                
            }
        }
    }