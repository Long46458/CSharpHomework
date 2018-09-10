using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double n = 0;
            double d = 0;
            Console.Write("Please input the first number:");
            s = Console.ReadLine();
            n = Double.Parse(s);
            Console.Write("Please input the second number:");
            s = Console.ReadLine();
            d = Double.Parse(s);
            Console.WriteLine("The answer is " + (n*d));

        }
    }
}
