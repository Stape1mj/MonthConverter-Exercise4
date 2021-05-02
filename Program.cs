using System;

namespace monthconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number 1-12");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 1 || num >12)
            {
                Console.WriteLine("That's not a number between 1 and 12");
            }

       else if (num == 1)
            {
                Console.WriteLine("January");
            }

       else if (num == 2)
            {
                Console.WriteLine("February");
            }

       else if (num == 3)
            {
                Console.WriteLine("March");
            }

       else if (num == 4)
            {
                Console.WriteLine("April");
            }

       else if (num == 5)
            {
                Console.WriteLine("May");
            }

       else if (num == 6)
            {
                Console.WriteLine("June");
            }

       else if (num == 7)
            {
                Console.WriteLine("July");
            }

       else if (num == 8)
            {
                Console.WriteLine("August");
            }

       else if (num == 9)
            {
                Console.WriteLine("September");
            }

       else if (num == 10)
            {
                Console.WriteLine("October");
            }

       else if (num == 11)
            {
                Console.WriteLine("November");
            }

       else if (num == 12)
            {
                Console.WriteLine("December");
            }


            // Exercise 4


            Console.WriteLine("\r\nGive me a number");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nGive me another number");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nWould you like to add, subtract, multiply or divide?");
            string input = Console.ReadLine();
            string input1 = input.ToLower();

           switch (input1)
            {
                case "add":
                    double add = (num1 + num2);
                Console.WriteLine($"{add}");
                    break;

                case "subtract":
                    double sub = (num1 - num2);
                    Console.WriteLine($"{sub}");
                    break;

                case "multiply":
                    double mult = (num1 * num2);
                    Console.WriteLine($"{mult}");
                    break;

                case "divide":
                    double div = (num1 / num2);
                    Console.WriteLine($"{div}");
                    break;

            }
        }
    }
}
