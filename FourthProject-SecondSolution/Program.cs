using System;

namespace SeventhProject
{
    class Time
    {
        int hours, minutes, seconds;

        public int Hours
        {
            set
            {
                if (value >= 0 && value < 24) hours = value;
                else Console.WriteLine("Hours's value is out of range");
            }
            get { return hours; }
        }
        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60) minutes = value;
                else Console.WriteLine("Minutes's value is out of range");
            }
            get { return minutes; }
        }
        public int Seconds
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
        public Time(int hours) : this(hours, 0)
        {
        }
        public Time(int hours, int minutes) : this(hours, minutes, 0)
        {
        }
        public Time(int hours, int minutes, int seconds)
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
        public void setTime(int hours)
        {
            setTime(hours, 0);
        }
        public void setTime(int hours, int minutes)
        {
            setTime(hours, minutes, 0);
        }
        public void setTime(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public void addExactHourValue(int addedValue)
        {
            if (hours + addedValue >= 24) hours = (hours + addedValue) % 24;
            else hours += addedValue;
        }
        public void addExactMinutesValue(int addedValue)
        {
            if (minutes + addedValue >= 60)
            {
                minutes = (minutes + addedValue) % 60;
                addExactHourValue((minutes + addedValue) / 60);
            }
            else minutes += addedValue;
        }

        public void addExactSecondsValue(int addedValue)
        {
            if (seconds + addedValue >= 60)
            {
                seconds = (seconds + addedValue) % 60;
                addExactMinutesValue((seconds + addedValue) / 60);
            }
            else seconds += addedValue;
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

            uaTime.addExactHourValue(2);
            uaTime.addExactMinutesValue(600);
            uaTime.addExactSecondsValue(22);
            uaTime.getTime();
        }
    }
}