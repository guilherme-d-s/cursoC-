using System;

namespace posto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível*/
            Console.WriteLine("Entre com o código do combustivel: ");
            Console.WriteLine("Para etanol digite 1, para gasolina digite 2, diesel 3 e para encerrar digite 4.");
            int etanol = 0;
            int gasolina = 0;
            int diesel = 0;

            int cod = int.Parse(Console.ReadLine());


            while (cod != 4)
            {
                if (cod == 1)
                {
                    etanol = etanol + 1;
                }
                else if (cod == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (cod <= 0)
                {
                    Console.WriteLine("Codigo indisponivel use apenas do 1 ao 4");
                }
                else if (cod >= 5)
                {
                    Console.WriteLine("Codigo indisponivel use apenas do 1 ao 4");
                }
                else if (cod == 3)
                {
                    diesel = diesel + 1;
                }
                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Etanol: " + etanol);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);



        }
    }
}
