using System;

namespace parImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Este número é par!");
            }
            else
            {
                Console.WriteLine("Este número é Ímpar");
            }
        }
    }
}
