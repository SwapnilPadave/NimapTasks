using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basic Lambda Expression
            //const int factor = 9;
            //Func<int, int> multiplier = n => n * factor;
            //var result = multiplier(10);
            //Console.WriteLine(result);


            //Func<int, int> Square = number => number * number;

            //Console.WriteLine(Square(9));
            #endregion
            // List to store numbers
            List<int> numbers = new List<int>() { 2, 4, 5, 6, 7, 8, 9, 15, 16, 19, 20 };

            // foreach loop to display the list
            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression
            // to calculate square of
            // each value in the list
            var square = numbers.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using Lambda expression to
            // find all numbers in the list
            // divisible by 2
            List<int> divBy2 = numbers.FindAll(x => (x % 2) == 0);

            // foreach loop to display divBy3
            Console.Write("Numbers Divisible by 2 : ");
            foreach (var value in divBy2)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }
    }
}
