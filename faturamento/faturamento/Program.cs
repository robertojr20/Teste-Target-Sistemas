/*3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, 
na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados 
no cálculo da média;*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace FaturamentoDistribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lê o conteúdo do arquivo JSON
            string json = File.ReadAllText("faturamento.json");

            // Converte o conteúdo JSON em uma lista de objetos
            List<FaturamentoDiario> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

            // Calcula o menor e o maior valor de faturamento
            double menorFaturamento = faturamento.Min(f => f.Valor);
            double maiorFaturamento = faturamento.Max(f => f.Valor);

            // Calcula a média mensal do faturamento, ignorando os dias sem faturamento
            double mediaMensal = faturamento.Where(f => f.Valor > 0).Average(f => f.Valor);

            // Calcula o número de dias no mês em que o faturamento diário foi superior à média mensal
            int diasAcimaDaMedia = faturamento.Count(f => f.Valor > mediaMensal);

            // Imprime os resultados
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
            Console.WriteLine($"Número de dias acima da média mensal: {diasAcimaDaMedia}");

            // Aguarda a tecla enter para encerrar o programa
            Console.ReadLine();
        }
    }

    // Classe que representa um objeto de faturamento diário
    class FaturamentoDiario
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}

