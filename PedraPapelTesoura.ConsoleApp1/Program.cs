using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
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

            if (!Desejacontinuar())
                break;
        }
    }

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=============================");
        Console.WriteLine("Pedra, Papel, Tesoura");
        Console.WriteLine("=============================");
        Console.ForegroundColor = ConsoleColor.White;
    }

    static bool Desejacontinuar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("DESEJA CONTINUAR? s/N ");
        Console.ForegroundColor = ConsoleColor.White;
        string? desejaContinuar = Console.ReadLine();

        if (desejaContinuar?.ToUpper() != "S")
            return false;
        return true;
    }
}