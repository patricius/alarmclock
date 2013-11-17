using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock2
{
    public class Alarm
    {
        public DateTime RingTime { get; set; }
        public DateTime CurrentTime { get; set; }
       
        

        public DateTime GetCurrentTime()
        {
            CurrentTime = DateTime.Now;
            return CurrentTime;
        }
        public  string GetUserInput()
        {
            AlarmTimer alarmTimer = new AlarmTimer();

            Console.Write("Enter time to display your message");
            string TimeasString = Console.ReadLine();
            DateTime alarmTime;
           
            bool validTime = DateTime.TryParse(TimeasString, out alarmTime);
            RingTime = alarmTime;
            Console.Write("Enter message");
            alarmTimer.Message = Console.ReadLine();

           return alarmTimer.Message;
        }


        public double CalculateTimeSpan()
        {
            TimeSpan difference = RingTime - CurrentTime;
            double milliseconds = difference.TotalMilliseconds;
            return Math.Round(milliseconds, 0);
        }

    }
}