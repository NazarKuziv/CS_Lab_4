using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_4
{
    public class Time
    {

        private int hours;
        private int minutes;
        private int seconds;

        public int GetHours() { return hours; }
        public int GetMinutes() { return minutes; }
        public int GetSeconds() { return seconds; }

        public bool SetHours(int value)
        {
            if (value >= 0 && value < 23) { hours = value; return true; }
            else { hours = 0; return false; }
        }
        public bool SetMinutes(int value)
        {
            if (value >= 0 && value < 60) { minutes = value; return true; }
            else { minutes = 0; return false; }
        }
        public bool SetSeconds(int value)
        {
            if (value >= 0 && value < 60) { seconds = value; return true; }
            else { seconds = 0; return false; }
        }
        public bool Init(int h, int m, int s)
        {
            return SetHours(h) && SetMinutes(m) && SetSeconds(s);
        }

        public void Read()
        {
            int h, m, s;

            do
            {
                Console.Write("Hour: ");
                h = Convert.ToInt32(Console.ReadLine());
                Console.Write("Minute: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second: ");
                s = Convert.ToInt32(Console.ReadLine());

            } while (!Init(h, m, s));
        }
        public void Display1()
        {
            if (hours == 1)
                Console.Write($" {hours} hour ");
            else
                Console.Write($" {hours} hours ");

            if (minutes == 1)
                Console.Write($"{minutes} minute ");
            else
                Console.Write($"{minutes} minutes ");

            if (seconds == 1)
                Console.WriteLine($" {seconds} second ");
            else
                Console.WriteLine($"{seconds} seconds ");

        }
        public void Display2()
        {
            if (hours < 12)
                Console.Write($" {hours+1} a.m ");
            else
            {
                int h = 1;
                for (int i = 12; i <= hours; i++)
                {
                    if (i == hours)
                        Console.Write($" {h} p.m ");
                    h++;
                }         

            }


            if (minutes == 1)
                Console.Write($"{minutes} minute ");
            else
                Console.Write($"{minutes} minutes ");

            if (seconds == 1)
                Console.Write($" {seconds} second ");
            else
                Console.Write($"{seconds} seconds ");

        }
    }
}

    


