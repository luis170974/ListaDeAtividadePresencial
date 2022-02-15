using System;

/*
 Desenhe um retângulo com asteriscos, onde as forem linhas pares escreva
"A" e as linhas ímpares escreva "B"
 */

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma largura: ");

            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma altura: ");

            int altura = Convert.ToInt32(Console.ReadLine());



            for (int j = 0; j < altura; j++)
            {
                Console.WriteLine(" ");

                for (int i = 0; i < largura; i++)
                {
                    if (j % 2 == 0)
                    {
                        
                            Console.Write("A");
                        }
                       
                    
                    else if(j % 2 == 1)
                    {
                            Console.Write("B");

                    }
                }

            }
            Console.ReadLine();

        }
    }
}



