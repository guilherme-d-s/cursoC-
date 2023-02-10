using System;
using System.Globalization;

namespace tabela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo do produto:");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade");
            int quant = int.Parse(Console.ReadLine());

            double total;
            if (cod == 1)
            {
                total = quant * 4.0;
            }
            else if (cod == 2)
            {
                total = quant * 4.5;
            }
            else if (cod == 3)
            {
                total = quant * 5.0;
            }
            else if (cod == 4)
            {
                total = quant * 2.0;
            }
            else
            {
                total = quant * 1.5;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
