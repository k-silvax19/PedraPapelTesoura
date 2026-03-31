using System.Reflection;
using System.Reflection.Metadata;
class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            ExibirCabecalho();

            string jogadaJogador = Jogador.ObterJogadaJogador();

            string jogadaComputador = Computador.ExecutarRodadaComputador();

            Rodada.ExecutarRodada(jogadaJogador, jogadaComputador);

            Console.Write("DESEJA CONTINUAR? s/N ");
            string? desejaContinuar = Console.ReadLine();

            if (desejaContinuar?.ToUpper() != "S")
                break;
        }
    }

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("Pedra, Papel e Tesoura");
        Console.WriteLine("=============================");
    }
}