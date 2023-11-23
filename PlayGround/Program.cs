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






           










            Console.ReadKey();

        }
    }
}
