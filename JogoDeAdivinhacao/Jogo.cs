namespace JogoDeAdivinhacao
{
    public static class Jogo
    {
        static int totalDeTentativas = 0;

        public static void DefinirTotalTentativas(int numeroDeTentativas)
        {
            totalDeTentativas = numeroDeTentativas;
        }

        public static int ObterTotalTentativas()
        {
            return totalDeTentativas;
        }

        public static void ExibirVitoria()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Você acertou o número secreto!");
            Console.WriteLine("-------------------------------------");
        }

        public static void ExibirDerrota(int numeroSecreto)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Que pena! Você não conseguiu acertar. O número secreto era " + numeroSecreto);
            Console.WriteLine("-------------------------------------");
        }

        public static void ExibirDica(string comparacao)
        {
            switch(comparacao)
            {
                case "Maior":
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O número informado é maior que o número secreto!");
                    Console.WriteLine("-------------------------------------");
                    break;
                case "Menor":
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O número informado é menor que o número secreto!");
                    Console.WriteLine("-------------------------------------");
                    break;
            }
        }
    }
}
