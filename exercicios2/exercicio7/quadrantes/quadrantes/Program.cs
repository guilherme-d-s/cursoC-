using System;
using System.Globalization;
namespace quadrantes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
            Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            situação.*/

            Console.WriteLine("Digite um decimal x");
            double decX = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um decimal y");
            double decY = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (decX == 0 && decY == 0)
            {
                Console.WriteLine("Esta na origem.");
            }
            else if (decX == 0)
            {
                Console.WriteLine("Esta no eixo Y");
            }
            else if (decY == 0)
            {
                Console.WriteLine("Esta no eixo X");
            }
            else if (decX > 0 && decY > 0)
            {
                Console.WriteLine("Esta no quadrante 1");
            }
            else if (decX < 0 && decY > 0)
            {
                Console.WriteLine("Esta no quadrante 2");
            }
            else if (decX < 0 && decY < 0)
            {
                Console.WriteLine("Esta no quadrante 3");
            }
            else Console.WriteLine("Esta no quadrante 4");
        }
    }
}
