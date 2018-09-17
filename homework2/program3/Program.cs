using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 2; i <= 100; i++)
            {
                int j=2;
                while (++j < 101)
                    if (i % j == 0) break; 
                                           
                if (j == i) Console.WriteLine(i+"是2—100的素数");

            }
            
        }
    }
}
