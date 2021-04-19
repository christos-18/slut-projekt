using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {


            int continueplaying = 1;

            RunGame();

            while (continueplaying == 1)
            {

                Console.WriteLine("Vill du spela igen, ja eller nej?", Console.ForegroundColor = ConsoleColor.White);


                string answer = Console.ReadLine();

                if (answer.ToLower() == "ja")
                {
                    Console.Clear();

                    RunGame();
                }
                else if (answer.ToLower() == "nej")
                {
                    continueplaying = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ogiltigt svar! \n");

                }


            }
        }





        static void RunGame()
        {




            Console.WriteLine("Tryck Enter en gång för att starta spelet");


           

                Console.WriteLine("\n ");

                Console.ReadLine();



            }


























        }


    }








