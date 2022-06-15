using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string author = "Swapnil Padave";
            string Class = "12th Std";
            int year = 2018;
            decimal price = 250;
            string hello = $"{author} is a student of {Class} . \n" +
            $"The fee is ${price} and was Passed in year {year}. ";
            Console.WriteLine(hello);

            int i = 10;
            int j = 41;
            string s = "";
            s = $"The Sum Of {i} And {j} \nIs = {i + j}";
            Console.WriteLine(s);
        }
    }
}

