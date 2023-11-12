using System;

namespace FirstApp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            /// TODO: To change Conosle.Color ////////////////
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("\n\tHello, World!");
            /*
                Console.Clear(); => this would clear the black background and 
                make it all green
            */
            ////////////////////////////////////////////////// 
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\tHello World and hello all C# devs! :) ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            // TODO: Prompt user for its name and save it to string variable 
            Console.Write("\n\tEnter Your name: ");
            string userName = Console.ReadLine();
            ////////////////////////////////////////////////// 


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\tIt's great to meet You {userName}!");




            Console.ReadKey();


        }
    }
}

    

    