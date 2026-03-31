class Jogador
{
    public static string ObterJogadaJogador()
    {
        string jogadaJogador = "";

        do
        {
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");

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
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;
            }
            return jogadaJogador;
        } while (true);
    }
}