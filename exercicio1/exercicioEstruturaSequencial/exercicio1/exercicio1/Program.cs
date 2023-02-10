using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número ");
            double n2 = double.Parse(Console.ReadLine());
            double soma = n1 + n2;

            Console.WriteLine("a soma dos números é: " + soma);
        }
    }
}
