class Jogador
{
    public static string ObterJogadaJogador()
    {
        string jogadaJogador = "";

        do
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 - Pedra");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2 - Papel");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3 - Tesoura");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite Uma Jogada: ");
            string? OperacaoSelecionada = Console.ReadLine();


            switch (OperacaoSelecionada)
            {
                case "1":
                    jogadaJogador = "Pedra";
                    break;

                case "2":
                    jogadaJogador = "Papel";
                    break;

                case "3":
                    jogadaJogador = "Tesoura";
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção inválida!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    continue;
            }
            return jogadaJogador;
        } while (true);
    }
}