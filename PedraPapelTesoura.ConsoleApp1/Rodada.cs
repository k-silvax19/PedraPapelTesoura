class Rodada
{
    public static void ExecutarRodada(string jogadaJogador, string jogadaComputador)
    {
        if (jogadaJogador == jogadaComputador)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Empate!, Você Jogou {jogadaJogador} e o Computador jogou {jogadaComputador}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (
            (jogadaJogador == "Pedra" && jogadaComputador == "Tesoura") ||
            (jogadaJogador == "Tesoura" && jogadaComputador == "Papel") ||
            (jogadaJogador == "Papel" && jogadaComputador == "Pedra")
        )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Você jogou {jogadaJogador} e o Computador Jogou {jogadaComputador}, Você venceu!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Computador jogou {jogadaComputador} e você jogou {jogadaJogador}, o Computador venceu!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}