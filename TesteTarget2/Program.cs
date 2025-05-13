using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o
//próximo valor sempre será a soma dos 2 valores anteriores
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um
//programa na linguagem que desejar onde, informado um número,
//ele calcule a sequência de Fibonacci e retorne uma mensagem
//avisando se o número informado pertence ou não a sequência.

//IMPORTANTE: Esse número pode ser informado através de qualquer
//entrada de sua preferência ou pode ser previamente definido no código;

namespace TesteTarget2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            while (b < numero)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            if (numero == a || numero == b)
                Console.WriteLine("O número pertence à sequência de Fibonacci.");
            else
                Console.WriteLine("O número NÃO pertence à sequência de Fibonacci.");
        }
    }
}