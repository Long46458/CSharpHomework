using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组中数字的个数：");//确定数组中元素的个数
            String s = "";
            s = Console.ReadLine();
            int i=0;
            i = Int32.Parse(s);
            int  max, min ;     
            int[] arr = new int[i];//建立数组
            for(int k=1;k<=i;k++)//从键盘获取每一个数
            {
                Console.WriteLine("请输入第" + k+"个数");
                string t = "";
                t = Console.ReadLine();
                arr[k-1] = Int32.Parse(t);

            }
            Array.Sort(arr);//排序
            max = arr[i-1];
            min = arr[0];
            int sum = 0;
            for (int j=0;j<i;j++)
            {
                sum = sum + arr[j];
            }
            Console.WriteLine("最大值为：" + max);//输出结果
            Console.WriteLine("最小值为：" + min);
            Console.WriteLine("和为：" + sum);
            double average;
            average = sum /i;
            Console.WriteLine("平均数为：" + average);



        }
    }
}
