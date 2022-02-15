using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            DateTime horaAtual = DateTime.Now;
            Console.WriteLine(horaAtual);

             

            if(horaAtual .Hour > 5 && horaAtual.Hour < 12)
            {
                Console.WriteLine("Bom dia");

            }
            
            else if(horaAtual .Hour > 12 && horaAtual.Hour < 17)
            {
                Console.WriteLine("Boa Tarde");
            }

            else if (horaAtual .Hour > 18)
            {
                Console.WriteLine("Boa noite");
            }

            Console.ReadKey();

        }
    }
}
