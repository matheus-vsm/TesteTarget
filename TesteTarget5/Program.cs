using System;
using System.Globalization;
using System.Text.Json;

//5) Escreva um programa que inverta os caracteres de um string.

//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua
//preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

namespace TesteTarget5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            char[] caracteres = palavra.ToCharArray();
            int tamanho = caracteres.Length;
            char[] palavraInvertida = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                palavraInvertida[i] = caracteres[tamanho - 1 - i];
            }

            string resultado = new string(palavraInvertida);
            Console.WriteLine($"Palavra invertida: {resultado}");
        }
    }
}