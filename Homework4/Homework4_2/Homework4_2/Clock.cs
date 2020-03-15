using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    public delegate void AlarmClock(object sender,Time args);
    public class Time
    {
        public int hour;
        public int minute;
        public int second;
        public void SetAlarmTime(int h,int m,int s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }
    }
    
    public class Clock
    {
        public event AlarmClock OnTick;
        public event AlarmClock OnAlarm;
        
        public void start(int h,int m,int s)
        {
            while (true)
            {
                Tick();
                Alarm(h, m, s);
                System.Threading.Thread.Sleep(1000);
            }
        }
        
        public void Tick()
        {
                OnTick(this,null);
        }
        public void Alarm(int h, int m, int s)
        {
            Time args = new Time();
            args.SetAlarmTime(h, m, s);
            if ((DateTime.Now.Hour.ToString()==args.hour.ToString())
                && (DateTime.Now.Minute.ToString()==args.minute.ToString())
                &&(DateTime.Now.Second.ToString()==args.second.ToString()))
                OnAlarm(this, args);
        }
    }
    public class RunTime
    {
        public Clock clock1 = new Clock();
        public RunTime()
        {
            clock1.OnTick += _OnTick;
            clock1.OnAlarm +=_OnAlarm;
        }
        void _OnTick(object sender, Time args)
        {
            Console.WriteLine($"时间在嘀嗒！现在时间是：{DateTime.Now.ToLongTimeString().ToString()}");
        }
        void _OnAlarm(object sender, Time args)
        {
            Console.WriteLine($"闹铃响了！现在时间是：{DateTime.Now.ToLongTimeString().ToString()}");
        }
    }
}
