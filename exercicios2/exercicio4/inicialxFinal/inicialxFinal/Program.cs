using System;

namespace inicialxFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas*/
            Console.WriteLine("Que horas começou o jogo?");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Que horas terminou o jogo?");
            int end = int.Parse(Console.ReadLine());

            int duration;
            if (start < end)
            {
                duration = end - start;
            }
            else
            {
                duration = 24 - start + end;
            }
            Console.WriteLine("O jogo durou " + duration + " hora(s)");


        }
    }
}
