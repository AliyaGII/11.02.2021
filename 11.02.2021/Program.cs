using System;

namespace _11._02._2021
{
    class Program
    {
        private delegate T Char<T>(dynamic num1, dynamic num2);
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Enter a first number:");
            var i = Int32.TryParse(Console.ReadLine(), out var num1);
            if (!i)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Enter a second number:");
            i = Int32.TryParse(Console.ReadLine(), out var num2);
            if (!i)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose operation :");
            Console.WriteLine($" 1. + \n 2. - \n 3. * \n 4. /");
            Console.ForegroundColor = ConsoleColor.White;


            i = Int32.TryParse(Console.ReadLine(), out var chr);
            if (!i)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Char<double> calculate = chr 
                switch
            { 
                1 => Summation<double>, 2 => Subtraction<double>, 3 => Multiplication<double>, 4 => Divide<double>,_ => null 
            };

            if (calculate == null)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            double result;
            try
            {
                result = calculate(num1, num2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Do not divide on zero");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Result is :  " + result);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static T Summation<T>(dynamic num1, dynamic num2) => num1 + num2;
        static T Subtraction<T>(dynamic num1, dynamic num2) => num1 - num2;
        static T Multiplication<T>(dynamic num1, dynamic num2) => num1 * num2;
        static T Divide<T>(dynamic num1, dynamic num2) => num1 / num2;
       
    }
}

