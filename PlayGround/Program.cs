using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace PlayGround
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to this awesome ToDo app!");
            Console.WriteLine();

            Console.WriteLine("[S]ee all Todos");
            Console.WriteLine("[A]dd Todo");
            Console.WriteLine("[R]emove a Todo");
            Console.WriteLine("[E]xit the app");

            char.TryParse(Console.ReadLine().ToLower(), out char c);


            List<string> todos = new List<string>();


            void LoopThrough(List<string> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            

            bool canContinue = true;
            while (canContinue)
            {

                switch (c)
                {
                    case 'e':
                        canContinue = false;
                        break;
                    case 's':
                        LoopThrough(todos);
                        break;
                    case 'a':
                        Console.Write("Add : ");
                        todos.Add(Console.ReadLine());
                        break;

                    case 'r':
                        try
                        {
                        todos.RemoveAt(todos.Count - 1);

                        } catch (Exception ex)
                        {
                            Console.WriteLine("There is no no more ToDos left ...");
                        }
                        break;
                    default:      
                        break;
                }
                if (!canContinue)
                {
                    break;
                }
                Console.Write("What would You like to do: ");
                char.TryParse(Console.ReadLine().ToLower(), out  c);


            }
            Console.WriteLine();
            Console.WriteLine("Thank You for using our app!");






            /*

            void PrevLessonLeftovers()
            {
                /// TODO: To change Conosle.Color ////////////////
                //Console.ForegroundColor = ConsoleColor.Black;
                //Console.BackgroundColor = ConsoleColor.DarkYellow;
                //Console.WriteLine("\n\tHello, World!");
                
                    Console.Clear(); => this would clear the black background and 
                    make it all green
                
                ////////////////////////////////////////////////// 
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\tHello World and hello all C# devs! :) ");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                // TODO: Prompt user for its name and save it to string variable 
                //Console.Write("\n\tEnter Your name: ");
                //string userName = Console.ReadLine();
                ////////////////////////////////////////////////// 


                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                //Console.WriteLine($"\tIt's great to meet You {userName}!");


                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                // TODO: Variables :

                bool canIVote = true;

                Console.WriteLine("\n");
                Console.WriteLine("The biggest Integer : {0}", int.MaxValue);
                Console.WriteLine("The smallest Integer : {0}", int.MinValue);

                Console.WriteLine("\n");
                Console.WriteLine("The biggest double : {0}", double.MaxValue);
                Console.WriteLine("The smallest double : {0}", double.MinValue);

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                string playListName = "CoolBands";
                Console.WriteLine("\n\tMy favorite Spotify playlist is '{0}'", playListName);



                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write("Enter Your age: ");
                int userAge = int.Parse(Console.ReadLine());


                Console.WriteLine($"Thats cool ! Im also {userAge}");

                Console.ReadKey();

            }
            */










            Console.ReadKey();

        }
    }
}
