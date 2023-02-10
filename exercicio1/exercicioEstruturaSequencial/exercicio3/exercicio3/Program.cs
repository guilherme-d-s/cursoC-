using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
           // de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).


            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número:");
            int n4 = int.Parse(Console.ReadLine());

            int diferenca = n1 * n2 - n3 * n4;
            Console.WriteLine("A diferença entre os números é: " + diferenca);

        }
    }
}
