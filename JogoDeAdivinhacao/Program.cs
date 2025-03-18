namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
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

                int totalDeTentativas = 0;

                Console.Write("Digite sua escolha de dificuldade: ");
                string opcaoDificuldade = Console.ReadLine();

                if (opcaoDificuldade == "1")
                    totalDeTentativas = 10;
                else if (opcaoDificuldade == "2")
                    totalDeTentativas = 5;
                else if (opcaoDificuldade == "3")
                    totalDeTentativas = 3;

                // gerar um número secreto aleatório
                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                // lógica das tentativas do jogo
                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                    Console.WriteLine("-------------------------------------");

                    // lógica do jogo
                    Console.Write("Digite um número entre 1 e 20: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Você acertou o número secreto!");
                        Console.WriteLine("-------------------------------------");

                        break;
                    }

                    if (tentativa == totalDeTentativas)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Que pena! Você não conseguiu acertar. O número secreto era " + numeroSecreto);
                        Console.WriteLine("-------------------------------------");

                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("O número informado é maior que o número secreto!");
                        Console.WriteLine("-------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("O número informado é menor que o número secreto!");
                        Console.WriteLine("-------------------------------------");
                    }

                    Console.Write("Aperte ENTER para continuar...");
                    Console.ReadLine();
                }

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}