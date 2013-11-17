using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            AlarmTimer alarmTimer = new AlarmTimer();

            Console.WriteLine("The current time is {0}", alarm.GetCurrentTime().ToString("h:mm tt"));
            Console.WriteLine();


            alarmTimer.Message = alarm.GetUserInput();

            alarmTimer.Milliseconds = alarm.CalculateTimeSpan();

            alarmTimer.CreateEvent();

            Console.ReadLine();


        }


    }
}
