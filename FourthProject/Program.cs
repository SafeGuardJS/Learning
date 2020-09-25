using System;

namespace FourthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Time newTime = new Time(-19, 5, -5);

            newTime.getCommonStyleTime();
            newTime.setTime(5, 5, 5);
            newTime.getCommonStyleTime();
        }
    }

    internal class Time
    {
        int hours;
        int minutes;
        int seconds;

        public int Hours
        {
            set
            {
                if(value >= 0 && value < 24)
                {
                    hours = value;
                }
                else
                {
                    Console.WriteLine("Hour's value is outside the range");
                }
            }
            get { return hours; }        
        }

        public int Minutes
        {
            set
            {
                if(value >= 0 && value < 59)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("Minute's value is outside the range");
                }
            }
            get { return minutes; }
        }

        public int Seconds
        {
            set
            {
                if(value >= 0 && value < 59)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("Second's value is outside the range");
                }
            }
            get { return seconds; }
        }

        public Time() : this(0)
        {
        }
        public Time(int hours) : this(hours, 0)
        {
        }
        public Time(int hours, int minutes) : this(hours, minutes, 0)
        {
        }
        public Time(int hours, int minutes, int seconds)
        {
            if(hours >= 0 && hours < 24)
            {
                this.hours = hours;
            }
            else
            {
                Console.WriteLine("Hour's value is outside the range");
            }

            if (minutes >= 0 && hours < 59)
            {
                this.minutes = minutes;
            }
            else
            {
                Console.WriteLine("Minute's value is outside the range");
            }

            if (seconds >= 0 && seconds < 24)
            {
                this.seconds = seconds;
            }
            else
            {
                Console.WriteLine("Second's value is outside the range");
            }
        }

        public void getCommonStyleTime()
        {
            string sHours, sMinutes, sSeconds;

            if(hours / 10 < 1) { sHours = "0" + hours.ToString(); } else { sHours = hours.ToString(); }
            if (minutes / 10 < 1) { sMinutes = "0" + minutes.ToString(); } else { sMinutes = minutes.ToString(); }
            if (seconds / 10 < 1) { sSeconds = "0" + seconds.ToString(); } else { sSeconds = seconds.ToString(); }

            Console.WriteLine($"Time: {sHours}:{sMinutes}:{sSeconds}");
        }

        public void setTime(int h, int m, int s)
        {
            if( h >= 0 && h < 24 && m >= 0 && m < 59 && s >= 0 && s < 59)
            {
                this.hours = h;
                this.minutes = m;
                this.seconds = s;
            }
            else
            {
                Console.WriteLine("Value outside the range");
            }
        }
    }       
}
