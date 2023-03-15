using System;

class Program
{
    static int Fibonacci(int numero)
    {
        if (numero == 0)
        {
            return 0;
        }
        else if (numero == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(numero - 1) + Fibonacci(numero - 2);
        }
    }

    static void Main(string[] args)
    {
        int numero_informado = 13;

        bool pertence_sequencia = false;
        for (int i = 0; Fibonacci(i) <= numero_informado; i++)
        {
            if (Fibonacci(i) == numero_informado)
            {
                pertence_sequencia = true;
                break;
            }
        }

        if (pertence_sequencia)
        {
            Console.WriteLine($"O número {numero_informado} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero_informado} não pertence à sequência de Fibonacci.");
        }
    }
}
