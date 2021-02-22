using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            int input2;
            bool CIA, NSA, FBI ,Output;

            input1 = Console.ReadLine();
            input2 = int.Parse(Console.ReadLine());

            if (input1 == "CIA")
            {
                input2 = input2 % 3;
                CIA = input2 == 0;
                
                Console.WriteLine(CIA);
            }

            else if (input1 == "FBI")
            {}

            else if (input1 == "NSA")
            {}

            else
                Console.WriteLine("Error");

            Console.ReadKey();
        }
    }
}
