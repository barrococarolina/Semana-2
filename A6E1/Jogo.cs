namespace A6E1
{
    public class Jogo
    {
        private bool Turno;
        private string[,] Tabuleiro = new string[3, 3];
        private int Rodada = 0;

        private string JogadorX;
        private string JogadorO;

        
        public Jogo()
        {
            JogadorX = String.Empty;
            JogadorO = String.Empty;

            Iniciar();
        }

        private void Iniciar()
        {
            Console.WriteLine("Jogo da Velha\n");
            Preencher();
            Desenhar();
        }

        private void Desenhar()
        {


            Console.Clear();

            Console.WriteLine($"Jogador X: {JogadorX} - Jogador O: {JogadorO}\n");

            Console.WriteLine($"{Tabuleiro[2, 0]} | {Tabuleiro[2, 1]} | {Tabuleiro[2, 2]}");
            Console.WriteLine("-------------");
            Console.WriteLine($"{Tabuleiro[1, 0]} | {Tabuleiro[1, 1]} | {Tabuleiro[1, 2]}");
            Console.WriteLine("-------------");
            Console.WriteLine($"{Tabuleiro[0, 0]} | {Tabuleiro[0, 1]} | {Tabuleiro[0, 2]}\n");

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
            return false;
        }

        private void Jogada()
        {
            bool Limite = Rodada > 0;
            bool Fim = Vencedor() || Limite;

            while (Fim)
            {
                Console.WriteLine("Escolha a posição que deseja jogar:");
                Console.WriteLine("> ");
                bool ValidarEntrada = int.TryParse(Console.ReadLine(), out int EscolhaDoJogador);

                if (ValidarEntrada)
                {
                    switch (EscolhaDoJogador)
                    {

                        case 7:
                            Tabuleiro[2, 0] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 8:
                            Tabuleiro[2, 1] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 9:
                            Tabuleiro[2, 2] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 4:
                            Tabuleiro[1, 0] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 5:
                            Tabuleiro[1, 1] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 6:
                            Tabuleiro[1, 2] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 1:
                            Tabuleiro[0, 0] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 2:
                            Tabuleiro[0, 1] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        case 3:
                            Tabuleiro[0, 2] = Turno ? "X" : "O";
                            Rodada--;
                            Desenhar();
                            Turno = !Turno;
                            break;

                        default:
                            Console.WriteLine("Valor inválido");
                            break;

                    }
                }

            }

        }
    }
}