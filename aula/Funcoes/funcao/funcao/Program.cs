using System;

namespace funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um programa que calcule três números e retorna o maior deles;
            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double result = bigger(n1, n2, n3);

            Console.WriteLine("O número maios é: " + result);
        }

        static int  bigger(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
