using System;

namespace Chapter01
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            //Print the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8 ...
            Console.WriteLine("EX10: Print the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8 ...");
            int x = 2;
            int y = -3;
            Console.Write("{0} {1} ", x, y);
            for (int i = 1; i < 100; i++)
            {
                x += 2;
                y -= 2;
                Console.Write("{0} {1} ", x, y);
            }
            Console.WriteLine();
        }
    }
}
