class Rodada
{
    public static void ExecutarRodada(string jogadaJogador, string jogadaComputador)
    {
        if (jogadaJogador == jogadaComputador)
        {
            Console.WriteLine($"Empate!, Você Jogou {jogadaJogador} e o Computador jogou {jogadaComputador}");
        }
        else if (
            (jogadaJogador == "Pedra" && jogadaComputador == "Tesoura") ||
            (jogadaJogador == "Tesoura" && jogadaComputador == "Papel") ||
            (jogadaJogador == "Papel" && jogadaComputador == "Pedra")
        )
        {
            Console.WriteLine($"Você jogou {jogadaJogador} e o Computador Jogou {jogadaComputador}, Você venceu!");
        }
        else
        {
            Console.WriteLine($"Computador jogou {jogadaComputador} e você jogou {jogadaJogador}, o Computador venceu!");
        }
    }
}