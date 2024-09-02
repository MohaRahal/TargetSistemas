using System;

class Program
{
    static void Main()
    {
        int ocorrencia = 0; // Nosso índice para contar o número de ocorrências da letra 'a' ou 'A'
        string str; // Nossa string para armazenar a frase

        Console.WriteLine("Insira uma palavra ou frase para a string:");
        str = Console.ReadLine(); // Captura da string pelo usuário

        // Loop para percorrer cada caractere da string
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'A')
            {
                ocorrencia++;
            }
        }

        if (ocorrencia == 0)
        {
            Console.WriteLine("A letra 'A' não foi inserida nenhuma vez.");
        }
        else
        {
            Console.WriteLine($"A letra 'A' foi inserida {ocorrencia} vezes.");
        }
    }
}
