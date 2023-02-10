using System;

namespace operadoresLogicos2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5;
            // && condição de igualdade, as duas concições devem ser iguais ou retornara false.
            bool c2 = 2 > 3 || 4 != 5;
            // || condição de OU, se alguma das condições forem verdadeiras retornara true.  
            bool c3 = !(2 > 3) && 4 != 5;
            // ! negação, ex: 2 não é maior que 3, logo retornara true.
            

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("------------ExemploExercicio----------------");

            bool c4 = 10 < 5; // false
            bool c5 = c1 || c2 && c3; //true
            //Operador logico && é lido primeiro e em seguida || logo retorna true ja que uma das condições são verdaeiras.
            // hierarquia da estrutura: ! > && > ||

            Console.WriteLine(c4);
            Console.WriteLine(c5);
        }
    }
}
