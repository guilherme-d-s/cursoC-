using System;

namespace negativoOuNao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            Console.WriteLine("Digite um número inteiro");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Este número é negativo");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero é nulo");
            }
            else
            {
                Console.WriteLine("Este número é positivo");
            }
        }
    }
}
