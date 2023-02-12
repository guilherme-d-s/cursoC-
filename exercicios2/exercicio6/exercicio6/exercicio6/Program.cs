using System;
using System.Globalization;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
              nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/

            Console.WriteLine("Entre com um valor:");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (value < 0.0 || value > 100.00)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (value < 25.0)
            {
                Console.WriteLine("Intervalor 0 a 25");
            }
            else if (value < 50.0)
            {
                Console.WriteLine("Intervalor 25 a 50");
            }
            else if (value < 75.0)
            {
                Console.WriteLine("Intervalor 50 a 75");
            }
            else 
            {
                Console.WriteLine("Intervalo 75 a 100");
            }
        }
    }
}