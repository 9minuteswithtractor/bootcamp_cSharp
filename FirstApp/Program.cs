using System;

namespace FirstApp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            /// TODO: To change Conosle.Color ////////////////
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            /*
                Console.Clear(); => this would clear the black background and 
                make it all green
            */
            ////////////////////////////////////////////////// 

            Console.WriteLine("\n\tHello, World!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\tHello and welcome, all C# devs! :) ");
            Console.ReadKey();


        }
    }
}

    

    