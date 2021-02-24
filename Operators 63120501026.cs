using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            int input2, a1, a2, a3, b1, b2, b3, c1, c2, c3, c4, c5, c6;
            bool CIA, NSA, FBI;

            input1 = Console.ReadLine();
            input2 = int.Parse(Console.ReadLine());



            if (input1 == "CIA")
            {
                a1 = (input2 % 10) % 3;
                a2 = input2 % 100 / 10;
                a3 = input2 % 10000 / 1000;

                CIA = (a1 == 0) && ((a2 != 1) && (a2 != 3) && (a2 != 5)) && (a3 >= 6 && a3 != 8);
                Console.WriteLine(CIA);
            }

            else if (input1 == "FBI")
            {
                b1 = input2 % 1000000 / 100000;
                b2 = input2 % 1000 / 100;
                b3 = input2 % 100000 / 10000;

                FBI = (b1 >= 4 && b1 <= 7) && (b2 != 6 && ((b2 % 2) == 0)) && (b3 % 2 != 0);
                Console.WriteLine(FBI);

            }

            else if (input1 == "NSA")
            {
                c1 = input2 % 10;
                c2 = input2 % 1000 / 100;
                c3 = input2 % 100 / 10;
                c4 = input2 % 10000 / 1000;
                c5 = input2 % 100000 / 10000;
                c6 = input2 % 1000000 / 100000;

                NSA = (30 % c1 == 0) && ((c2 % 3 == 0) && (c2 % 2 != 0)) && (c1 == 7 || c2 == 7 || c3 == 7 || c4 == 7 || c5 == 7 || c6 == 7);
                Console.WriteLine(NSA);
            }

            else
                Console.WriteLine("Wrong Password!");

            Console.ReadKey();
        }
    }
}
