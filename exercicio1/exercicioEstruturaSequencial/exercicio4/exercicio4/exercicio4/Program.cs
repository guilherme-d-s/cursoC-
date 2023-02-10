using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionario: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque aqui as horas trabalhadas: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora quanto ele ganha por hora: ");
            double ganhosHora = double.Parse(Console.ReadLine());
            double ganhoTotal = horasTrabalhadas * ganhosHora;
            Console.WriteLine("O Funcionario " + numeroFuncionario + " recebe " + ganhoTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
