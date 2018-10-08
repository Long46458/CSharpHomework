using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ClockEventArgs : EventArgs
    {
     public DateTime Time
        {   set;
            get;
        }
    }


    //声明一个委托

    public delegate void ClockEventHandler(object sender, ClockEventArgs e);
    class Clock
    {
        //在委托的机制下我们建立事件

        public event ClockEventHandler OnTime;



        public void SetAlarm(DateTime time)
        //如果有人注册了这个事件，也就是这个事件不是空

        {
            if (OnTime != null)
            {
                ClockEventArgs args = new ClockEventArgs();
                args.Time = time;
                OnTime(this, args);
            }
        }
    }
}
