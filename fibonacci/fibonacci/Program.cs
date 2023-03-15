/*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores
 anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,
 informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número 
 informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente 
definido no código;*/

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
