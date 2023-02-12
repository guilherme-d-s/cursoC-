using System;
using System.Globalization;
namespace imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Descrição do exercicio muito grande, ver o arquivo pdf na mesma pasta
            Console.WriteLine("Entre com seu salario:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax;
            if (salary <= 2000.00)
            {
                tax = 0.0;
            }
            else if (salary <= 3000.00)
            {
                tax = (salary - 2000.00) * 8 / 100;
            }
            else if (salary <= 4500)
            {
                tax = (salary - 3000.00) * 18 / 100 + 1000.00 * 8 / 100;
            }
            else
            {
                tax = (salary - 4500.00) * 28 / 100 + 1500.00 * 18 / 100 + 1000.00 * 8 / 100;
            }
            if (tax == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
