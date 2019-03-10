using System;

namespace Chapter09
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            //1.Write a code that by given name prints on the console "Hello, <name>!"
            //(for example: "Hello, Peter!").
            Console.Write("EX1: Enter your name: ");
            string name = Console.ReadLine();
            PrintHelloAnyBody(name);
            EndOfScript();
        }
        
        static void PrintHelloAnyBody(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        //support methods
        static void EndOfScript()
        {
            Console.WriteLine(new string('#', 80));
            Console.WriteLine();
        }
    }
}
