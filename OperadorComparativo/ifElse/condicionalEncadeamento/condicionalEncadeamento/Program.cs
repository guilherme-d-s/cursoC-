using System;

namespace condicionalEncadeamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }


            /*if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            if (hora >= 18)
            {
                Console.WriteLine("Boa noite!");
            */
        }
    }
}
