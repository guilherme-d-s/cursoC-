using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o raio do circulo: ");
            double R = double.Parse(Console.ReadLine());

            double calculo = R * R * pi;
            Console.WriteLine("A area é de: " + calculo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
