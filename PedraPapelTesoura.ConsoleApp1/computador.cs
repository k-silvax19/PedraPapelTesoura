using System.Security.Cryptography;
class Computador
{
    public static string ExecutarRodadaComputador()
    {
        string jogadaComputador;
        int numeroComputador = RandomNumberGenerator.GetInt32(1, 4);

        do
        {
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
        } while (true);
    }
}