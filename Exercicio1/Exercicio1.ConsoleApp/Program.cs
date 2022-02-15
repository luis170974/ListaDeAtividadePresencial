using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma largura: ");

            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma altura: ");

            int altura = Convert.ToInt32(Console.ReadLine());



            for(int j = 0; j < altura; j++)
            {
                Console.WriteLine(" ");

            for (int i = 0; i < largura; i++)
                {

                    Console.Write("* ");


                }

            }

            

        }
    }
}
