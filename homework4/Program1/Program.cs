using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock theClock = new Clock();
            theClock.OnTime += ItISOnTime;
            DateTime time = DateTime.Now;
            bool flag = true;
            while (flag)
            {
                //异常处理
                try
                {
                    Console.Write("Please input the hour:");//时间设定
                    int clockHour = int.Parse(Console.ReadLine());
                    Console.Write("Please input the minute:");
                    int clockMinute = int.Parse(Console.ReadLine());
                    time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, clockHour, clockMinute, 0);
                    if (time < DateTime.Now)
                    {
                        Console.WriteLine("wrong");
                        continue;
                    }
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("wrong");
                }
            }
            theClock.SetAlarm(time);
            Console.ReadKey();
        }
        static void ItISOnTime(object sender, ClockEventArgs e)
        {
            while (e.Time > DateTime.Now)
            {
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("linglingling！！！");
            while (true)
            {
                Console.Beep();
            }
        }
    }
}
