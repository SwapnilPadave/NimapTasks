using System;
using System.Text;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder ABC = new StringBuilder("My Name Is Swapnil ");
            Console.WriteLine(ABC);

            ABC.Append("I Am 28 Years Old");
            Console.WriteLine(ABC);

            int Salary = 10000;
            ABC.AppendFormat(" My salary is : {0:C}. ", Salary);
            Console.WriteLine(ABC);

            ABC.Insert(19, "Live In Mumbai ");
            Console.WriteLine(ABC);

            //ABC.Remove(11, 10);
            //Console.WriteLine(ABC);

            ABC.Replace("Mumbai", "India");
            Console.WriteLine(ABC);

            Console.ReadKey();
        }
    }
}
