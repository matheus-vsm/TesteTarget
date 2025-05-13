using System;
using System.Globalization;
using System.Text.Json;
using TesteTarget3.Entities;

//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora,
//faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

//IMPORTANTE:
//a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
//b) Podem existir dias sem faturamento, como nos finais de semana e feriados.
//Estes dias devem ser ignorados no cálculo da média;

namespace TesteTarget3
{
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            //string arquivo = "C:\\PROGRAMACAO\\TesteTarget\\TesteTarget3\\BaseDeDados\\dados.json";
            string arquivo = "TesteTarget3\\BaseDeDados\\dados.json";

            if (!File.Exists(arquivo))
            {
                Console.WriteLine("Arquivo 'dados.json' não encontrado.");
                return;
            }

            string json = File.ReadAllText(arquivo);

            List<Dados> dados = JsonSerializer.Deserialize<List<Dados>>(json);

            if (dados == null || dados.Count == 0)
            {
                Console.WriteLine("Arquivo JSON está vazio ou com formato inválido.");
                return;
            }
        }
    }
}