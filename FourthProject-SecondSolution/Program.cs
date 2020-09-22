using System;

namespace SeventhProject
{
    class Time
    {
        byte hours, minutes, seconds;

        public byte Hours
        {
            set
            {
                if (value >= 0 && value < 24) hours = value;
                else Console.WriteLine("Hours's value is out of range");
            }
            get { return hours; }
        }
        public byte Minutes
        {
            set
            {
                if (value >= 0 && value < 60) minutes = value;
                else Console.WriteLine("Minutes's value is out of range");
            }
            get { return minutes; }
        }
        public byte Seconds
        {
            set
            {
                if (value >= 0 && value < 60) seconds = value;
                else Console.WriteLine("Seconds's value is out of range");
            }
            get { return seconds; }
        }

        public Time() : this(0)
        {
        }
        public Time(byte hours) : this(hours, 0)
        {
        }
        public Time(byte hours, byte minutes) : this(hours, minutes, 0)
        {
        }
        public Time(byte hours, byte minutes, byte seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public void getTime()
        {
            if (hours < 10) Console.Write($"0{hours}:");
            else Console.Write($"{hours}:");

            if (minutes < 10) Console.Write($"0{minutes}:");
            else Console.Write($"{minutes}:");

            if (seconds < 10) Console.Write($"0{seconds}\n");
            else Console.Write($"{seconds}\n");
        }

        public void setTime()
        {
            setTime(0);
        }
        public void setTime(byte hours)
        {
            setTime(hours, 0);
        }
        public void setTime(byte hours, byte minutes)
        {
            setTime(hours, minutes, 0);
        }
        public void setTime(byte hours, byte minutes, byte seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time uaTime = new Time(26, 96, 60);
            uaTime.getTime();

            uaTime.setTime(22, 22, 22);
            uaTime.getTime();

            uaTime.Seconds = 59;
            uaTime.getTime();
        }
    }
}