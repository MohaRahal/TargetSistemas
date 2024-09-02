using System;

class Program
{
    static void Main()
    {
        int INDICE = 12; 
        int SOMA = 0; 
        int K = 1;

        while (K < INDICE) // Usando o laço while
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine(SOMA); // SOMA = 77
    }
}
