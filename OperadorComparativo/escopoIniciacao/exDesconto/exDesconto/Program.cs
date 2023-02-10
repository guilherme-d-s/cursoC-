using System;

namespace exDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double discount = 0.0;

            if (price > 100.0)
            {
                discount = price * 0.1;
            }

            Console.WriteLine(discount);
        }
    }
}
