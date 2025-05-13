using System;
using System.Globalization;
using System.Text.Json;

//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de
//representação que cada estado teve dentro do valor total mensal da distribuidora.  

namespace TesteTarget4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> faturamentoMensal = new Dictionary<string, double>();

            faturamentoMensal["SP"] = 67836.43;
            faturamentoMensal["RJ"] = 36678.66;
            faturamentoMensal["MG"] = 29229.88;
            faturamentoMensal["ES"] = 27165.48;
            faturamentoMensal["Outros"] = 19849.53;

            double totalFaturamento = 0;

            foreach (var estado in faturamentoMensal)
            {
                totalFaturamento += estado.Value;
            }

            Dictionary<string, double> percentualEstado = new Dictionary<string, double>();

            foreach (var estado in faturamentoMensal)
            {
                percentualEstado[estado.Key] = (estado.Value / totalFaturamento) * 100;
            }

            Console.WriteLine("Percentual de representação por estado:");
            foreach (var estado in percentualEstado)
            {
                Console.WriteLine($"{estado.Key}: {estado.Value.ToString("F2", CultureInfo.InvariantCulture)}%");
            }
        }
    }
}