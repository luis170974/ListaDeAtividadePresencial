using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



                Console.WriteLine("Digite o nome do jogador 1");
                string jogador1 = Console.ReadLine();

                Console.WriteLine("Digite o nome do jogador 2");
                string jogador2 = Console.ReadLine();

                for (int i = 1; i < 4; i++)
                {
                    Random rdn = new Random();
                    int quantidadeWins1 = 0; 
                    int quantidadeWins2 = 0;
                    int randomNumber1 = rdn.Next(6);
                    int randomNumber2 = rdn.Next(6);

                    Console.WriteLine(i + " rodada: ");

                    Console.WriteLine(jogador1 + ": " + randomNumber1);

                    Console.WriteLine(jogador2 + ": " + randomNumber2);





                     if (randomNumber1 > randomNumber2)
                    {
                        Console.WriteLine("Parabens: " + jogador1 + "ganhou");
                        quantidadeWins1++;


                    }

                    else if (randomNumber2 > randomNumber1)
                    {

                        Console.WriteLine("Parabens: " + jogador2 + " ganhou");
                        quantidadeWins2++;


                    }

                    else if(quantidadeWins1 > quantidadeWins2)
                {
                    Console.WriteLine("O jogador" + jogador1 + "Ganhou com" + quantidadeWins1);
                }

                else if (quantidadeWins2 > quantidadeWins1)
                {
                    Console.WriteLine("O jogador" + jogador2 + "Ganhou com" + quantidadeWins2);
                }

                else if (randomNumber1 == randomNumber2)
                {
                    Console.WriteLine("Houve empate!");

                    break;
                }


            }

                
            }
            

        }
    }

