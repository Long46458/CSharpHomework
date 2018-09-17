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
            int num=0;
            String s = "";
            Console.WriteLine("请输入一个正整数：");
            s = Console.ReadLine();
            num = Int32.Parse(s);
            for(int i=2;i<num;i++)
            {
                if (num % i== 0)
                {
                    int j = 1;
                    while (++j < i)
                        if (i % j == 0) break; // 遇到非1的因子，则表示i不是素数,
                                               // 终止循环
                    if (j == i) Console.WriteLine(i+"是该整数的素数因子");
                }
            }

        }
    }
}
    

