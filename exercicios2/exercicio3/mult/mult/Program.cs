using System;

namespace mult
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            ordem crescente ou decrescente.*/
            Console.WriteLine("Digite um número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um número");
            int b = int.Parse(Console.ReadLine());

            if (a % 2 + (b % 2) == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }



        }
    }
}
