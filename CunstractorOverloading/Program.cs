using System;
namespace Program
{
    class AddNumbers
    {
        int x;
        double y;
        string z;
        public AddNumbers()
        {
            x = 0;
        }
        public AddNumbers(int a, double b)
        {
            x = a;
            y = b;
        }
        public AddNumbers(int a, string b)
        {
            x = a;
            z = b;
        }
        public void show()
        {
            Console.WriteLine("1st constructor (int + float): {0} ",
                                                           (x + y));
        }

        // shows 2nd constructor's result
        public void show1()
        {
            Console.WriteLine("2nd constructor (int + string): {0}",
                                                           (x + z));
        }
    }
    public void Main(string[] args)
    {
        Console.WriteLine();
    }
    
   
}