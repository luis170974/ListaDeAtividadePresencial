using System;

/*
 Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a
média aritmética dos valores lidos, a quantidade de valores positivos e a
quantidade de valores negativos.
 */

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidaDeValoresPar = 0;
            int quantidadeValorImpar = 0;



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os valores");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor < 0)
                {
                    Console.WriteLine("O valor é negativo " + valor);
                    quantidadeValorImpar++;
                }
                else
                {
                    Console.WriteLine("O valor é positivo " + valor);
                    quantidaDeValoresPar++;
                }



            }



            Console.WriteLine("A quantidade de numeros positivos: " + quantidaDeValoresPar);
            Console.WriteLine("A quantidade de numeros negativos: " + quantidadeValorImpar);
        }
    }
}
