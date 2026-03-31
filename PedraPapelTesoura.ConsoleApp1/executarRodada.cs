class Rodada
{
    public static void ExecutarRodada(string jogadaJogador, string jogadaComputador)
    {
        if (jogadaJogador == jogadaComputador)
        {
            Console.WriteLine("Empate!");
        }
        else if (
            (jogadaJogador == "Pedra" && jogadaComputador == "Tesoura") ||
            (jogadaJogador == "Tesoura" && jogadaComputador == "Papel") ||
            (jogadaJogador == "Papel" && jogadaComputador == "Pedra")
        )
        {
            Console.WriteLine($"Você jogou {jogadaJogador}, você venceu");
        }
        else
        {
            Console.WriteLine($"Computador jogou {jogadaComputador}, o Computador venceu!");
        }
    }
}