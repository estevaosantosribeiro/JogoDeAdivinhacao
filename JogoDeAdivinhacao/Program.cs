namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string opcaoDificuldade = ExibirMenu();

                if (OpcaoUmForEscolhida(opcaoDificuldade))
                    Jogo.DefinirTotalTentativas(10);
                else if (OpcaoDoisFoiEscolhida(opcaoDificuldade))
                    Jogo.DefinirTotalTentativas(5);
                else if (OpcaoTresFoiEscolhida(opcaoDificuldade))
                    Jogo.DefinirTotalTentativas(3);

                int totalDeTentativas = Jogo.ObterTotalTentativas();

                // gerar um número secreto aleatório
                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    ExibirNumeroDeTentativas(tentativa, totalDeTentativas);

                    Console.Write("Digite um número entre 1 e 20: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Jogo.ExibirVitoria();
                        break;
                    }
                    if (tentativa == totalDeTentativas)
                    {
                        Jogo.ExibirDerrota(numeroSecreto);
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Jogo.ExibirDica("Maior");
                    }
                    else
                    {
                        Jogo.ExibirDica("Menor");
                    }

                    Console.Write("Aperte ENTER para continuar...");
                    Console.ReadLine();
                }
                
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (OpcaoSairForEscolhida(opcaoContinuar))
                    break;
            }
        }

        static bool OpcaoUmForEscolhida(string opcao)
        {
            bool opcaoUmFoiEscolhida = opcao == "1";

            return opcaoUmFoiEscolhida;
        }

        static bool OpcaoDoisFoiEscolhida(string opcao)
        {
            bool opcaoDoisFoiEscolhida = opcao == "2";

            return opcaoDoisFoiEscolhida;
        }

        static bool OpcaoTresFoiEscolhida(string opcao)
        {
            bool opcaoTresFoiEscolhida = opcao == "3";

            return opcaoTresFoiEscolhida;
        }

        static bool OpcaoSairForEscolhida(string opcao)
        {
            bool opcaoSairFoiEscolhida = opcao == "S";
            return opcaoSairFoiEscolhida;
        }

        static string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Escolha um nível de dificuldade:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");

            Console.Write("Digite sua escolha de dificuldade: ");
            string opcaoDificuldade = Console.ReadLine();

            return opcaoDificuldade;
        }

        static void ExibirNumeroDeTentativas(int tentativa, int totalDeTentativas)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
