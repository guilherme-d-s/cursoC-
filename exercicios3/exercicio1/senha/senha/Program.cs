using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.*/

            Console.Write("Digite sua senha: ");

            double pass = double.Parse(Console.ReadLine());

            double cpass = 2002;
            while (pass != cpass)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite sua senha: ");
                pass = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido.");
        }
    }
}
