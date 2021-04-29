using System;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {


            string[,] inventory = new string[2, 2];
            inventory[0,0] = RumEtt(inventory);
            Console.WriteLine("Du har 3 platser kvar");
            inventory[0,1] = RumTvå(inventory);
            Console.WriteLine("Du har 2 platser kvar");
            inventory[1,0] = RumTre(inventory);
            Console.WriteLine("Du har 1 plats kvar");
            inventory[1,1] = RumFyra(inventory);
            Console.WriteLine("Du har 0 platser kvar");
            ShowInventory(inventory);






            Console.ReadLine();


            int continueplaying = 1;
            

            RunGame(); // RunGame är metoden där spelet kommer loopas i och när man väl är färdig så frågar den ifall man vill spela igen eller avsluta programet. 

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
        

        static string RumEtt(string[,] inventory) // Här kommer det komma 4 rum där man kommer kunna plocka upp olika föremål. I varje rum är det max 3 alternativ man kan välja. 
        {
            Console.WriteLine("I detta rum finns det 3 föremål att plocka upp");
            Console.WriteLine("Skriv vilket föremål du vill plocka upp 1, 2 eller 3");
            Console.WriteLine("1. Svärd Level 1");
            Console.WriteLine("2. Sköld");
            Console.WriteLine("3. Snabba dojor");

            int val = LäsInInt(); 
            string item = "";
            

            if (val == 1)
            {
                item = "Svärd Level 1";
            }
            else if(val == 2)
            {
                item = "Sköld";
            }
            else
            {
                item = "Snabba Dojor";
            }
            inventory[0, 0] = item; // Föremålet man väljer kommer den att hamna i inventoryt på plats 0, 0
            return inventory[0, 0];


        }
        static string RumTvå(string[,] inventory) // static string för att det ska vara möjligt att returnera informationen
        {
            Console.Clear();

            Console.WriteLine("I detta rum finns det 3 föremål att plocka upp");
            Console.WriteLine("Skriv vilket föremål du vill plocka upp 1, 2 eller 3");
            Console.WriteLine("1. +20 Amor");
            Console.WriteLine("2. +20 Magic resistance");
            Console.WriteLine("3. 2000 Guld");

            int val = LäsInInt();
            string item = "";

            if (val == 1)
            {
                item = "+20 Amor";
            }
            else if (val == 2)
            {
                item = "+20 Magic resistance";
            }
            else
            {
                item = "2000 Guld";
                
             }
            inventory[0, 1] = item; // Föremålet man väljer kommer den att hamna i inventoryt på plats 0, 1
            return inventory[0, 1];


        }
        static string RumTre(string[,] inventory)
        {
            Console.Clear();

            Console.WriteLine("I detta rum finns det 3 föremål att plocka upp");
            Console.WriteLine("Skriv vilket föremål du vill plocka upp 1, 2 eller 3");
            Console.WriteLine("1. Stort svärd 200dmg/s");
            Console.WriteLine("2. +50 Armor");
            Console.WriteLine("3. +50 Magic resistance");

            int val = LäsInInt();
            string item = "";

            if (val == 1)
            {
                item = "Stort svärd 200dmg/s";
            }
            else if (val == 2)
            {
                item = "+50 Armor";
            }
            else
            {
                item = "+50 Magic resistance";
            }
            inventory[1, 0] = item; // Föremålet man väljer kommer den att hamna i inventoryt på plats 1, 0
            return inventory[1, 0];
        }
        static string RumFyra(string[,] inventory)
        {
            Console.Clear();

            Console.WriteLine("I detta rum finns det 3 föremål att plocka upp");
            Console.WriteLine("Skriv vilket föremål du vill plocka upp 1, 2 eller 3");
            Console.WriteLine("1. a");
            Console.WriteLine("2. b");
            Console.WriteLine("3. 5000 Guld");

            int val = LäsInInt();
            string item = "";

            if (val == 1)
            {
                item = "a";
            }
            else if (val == 2)
            {
                item = "b";
            }
            else
            {
                item = "5000 Guld";
            }
            inventory[1, 1] = item; // Föremålet man väljer kommer den att hamna i inventoryt på plats 1, 1
            return inventory[1, 1];
        }

        static void ShowInventory(string[,] inventory)
        {
            Console.Clear();

            Console.WriteLine("Detta är ditt inventory just nu!");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(inventory[i,j]);
                }
            }
          
        }

        static void Boss()
        {

        }



        static int LäsInInt() // När man skriver in vilket föremål man ska ha är det viktigt att så till att spelet vet hur de ska agera när man trycker på andra knappar.
        //Jag slipper skriva om den här delen i alla rum genom att bara kalla på den här metoden istället. 
        {
            int val = 0;
            while (true)
            {
                try
                {
                    val = int.Parse(Console.ReadLine());
                    if (val > 3 || val < 1)
                    {
                        Console.WriteLine("Du har skrivit in ett ogiltigt svar, Prova igen!");
                        continue;
                    }
                    else
                    {
                        break; 
                    }

                }
                catch
                {
                    Console.WriteLine("Du har skrivit in ett ogiltigt svar, Prova igen!");
                    
                }

            }
            return val;
        }





            

            


        }


    }








