using System;

class Program
{
    // Função recursiva para calcular o  termo da sequência de Fibonacci
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // Função para verificar se um número pertence à sequência de Fibonacci
    static bool PertenceFibonacci(int n)
    {
        int i = 0;
        int fib;

        // Calcula os números de Fibonacci até o número informado ou até passar dele
        while (true)
        {
            fib = Fibonacci(i);
            if (fib == n)
            {
                return true;  // Retorna true se o número pertence à sequência
            }
            if (fib > n)
            {
                return false;  // Retorna false se o número não pertence à sequência
            }
            i++;
        }
    }

    static void Main()
    {
        Console.Write("Informe um número: ");
        int num;
        if (int.TryParse(Console.ReadLine(), out num))
        {
            // Chama a função PertenceFibonacci e exibe o resultado
            if (PertenceFibonacci(num))
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {num} NÃO pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, informe um número inteiro.");
        }
    }
}
