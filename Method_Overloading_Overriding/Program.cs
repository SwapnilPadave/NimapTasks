using System;

namespace Method_Overloading_Overriding
{
    #region    // Method Overloading
    //class Program
    //{

    //    int a;
    //    int b;
    //    int c;
    //    string x;
    //    string y;
    //    public int Add(int a, int b)
    //    {
    //        return (a + b);
    //    }
    //    public int Add(int a, int b, int c)
    //    {
    //        return (a + b + c);
    //    }

    //    public string Add(string x, string y)
    //    {
    //        return (x + " " + y);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program objProgram = new Program();
    //        Console.WriteLine("Add with two int parameter :" + objProgram.Add(10, 11));
    //        Console.WriteLine("Add with three int parameter :" + objProgram.Add(10, 11, 30));
    //        Console.WriteLine("Add with two string parameter :" + objProgram.Add("Swapnil", "Padave"));
    //        Console.ReadLine();
    //    }
    //}
    #endregion

    #region Method Overriding
    //class BaseClass
    //    {
    //        public virtual int Add(int num1, int num2)
    //        {
    //            return (num1 + num2);
    //        }
    //    }
    //    class ChildClass : BaseClass
    //    {
    //        public override int Add(int num1, int num2)
    //        {
    //            if (num1 <= 0 || num2 <= 0)
    //            {
    //                Console.WriteLine("Values could not be less than zero or equals to zero");
    //                Console.WriteLine("Enter First value : ");
    //                num1 = Convert.ToInt32(Console.ReadLine());
    //                Console.WriteLine("Enter Second value : ");
    //                num2 = Convert.ToInt32(Console.ReadLine());
    //            }
    //            return (num1 + num2);
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            BaseClass baseClassObj;
    //            baseClassObj = new BaseClass();
    //            Console.WriteLine("Base class method Add :" + baseClassObj.Add(13, 8));
    //            baseClassObj = new ChildClass();
    //            Console.WriteLine("Child class method Add :" + baseClassObj.Add(-23, 2));
    //            Console.ReadLine();
    //        }
    //    }
    #endregion
}

