/*4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado 
teve dentro do valor total mensal da distribuidora.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Define um array com os valores de faturamento de cada estado
        decimal[] valoresEstados = { 67836.43m, 36678.66m, 29229.88m, 27165.48m, 19849.53m };

        // Calcula o valor total mensal da distribuidora a partir do array de valores dos estados
        decimal valorTotal = valoresEstados.Sum();

        // Exibe o percentual de representação de cada estado em relação ao valor total mensal da distribuidora
        Console.WriteLine("Percentual de representação de cada estado:");
        foreach (decimal valorEstado in valoresEstados)
        {
            // Calcula o percentual de representação do estado
            decimal percentual = (valorEstado / valorTotal) * 100;

            // Exibe o percentual de representação do estado com duas casas decimais
            Console.WriteLine($"{percentual:N2}%");
        }
    }
}
