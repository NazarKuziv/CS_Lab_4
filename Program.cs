using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            t.Read();
            Console.WriteLine("First output option:");
            t.Display1();
            Console.WriteLine("Second output option:");
            t.Display2();

            Console.ReadKey();
        }
    }
}
