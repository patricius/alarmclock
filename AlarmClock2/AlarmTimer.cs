using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AlarmClock2
{
     
    public class AlarmTimer
    {

        public string Message { get; set; }
        private static System.Timers.Timer aTimer;
        public double Milliseconds { get; set; }

        public void CreateEvent()
        {
            aTimer = new Timer(Milliseconds);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
     
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            OutputMessage();
        }

        public void OutputMessage()
        {

            Console.WriteLine("Here is your input: {0}", Message);
            Console.Beep(32767, 1000);
        }


    }
}
