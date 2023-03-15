/*5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente 
   definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;*/


using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string str = Console.ReadLine();

        string invertedStr = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            invertedStr += str[i];
        }

        Console.WriteLine("A string invertida é: " + invertedStr);
    }
}

