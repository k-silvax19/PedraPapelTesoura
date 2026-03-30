using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            ExibirCabecalho();

            string jogadaJogador = ObterJogadaJogador();

            string jogadaComputador = ExecutarRodadaComputador();

            ExecutarRodada(jogadaJogador, jogadaComputador);

            Console.Write("DESEJA CONTINUAR? s/N ");
            string? desejaContinuar = Console.ReadLine();

            if (desejaContinuar?.ToUpper() != "S")
                break;
        }
    }

    static string ExecutarRodadaComputador()
    {
        string jogadaComputador;

        int numeroComputador = RandomNumberGenerator.GetInt32(1, 4);
        if (numeroComputador == 1)
        {
            jogadaComputador = "Pedra";
        }
        else if (numeroComputador == 2)
        {
            jogadaComputador = "Papel";
        }
        else
        {
            jogadaComputador = "Tesoura";
        }

        return jogadaComputador;
    }

    static void ExecutarRodada(string jogadaJogador, string jogadaComputador)
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

    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("Pedra, Papel e Tesoura");
        Console.WriteLine("=============================");
    }

    static string ObterJogadaJogador()
    {
        Console.WriteLine("1 - Pedra");
        Console.WriteLine("2 - Papel");
        Console.WriteLine("3 - Tesoura");

        Console.Write("Digite Uma Jogada: ");
        string? OperacaoSelecionada = Console.ReadLine();

        string jogadaJogador = "";

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
    }
}