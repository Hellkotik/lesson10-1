using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //clock.hour=Convert.ToInt32(Console.ReadLine());
            //clock.min = Convert.ToInt32(Console.ReadLine());
            //clock.sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите часы");
            int h=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int s = Convert.ToInt32(Console.ReadLine());
            Clock clock= new Clock(h, m, s);
            //Clock clock = new Clock() { hour=h, min=m, sec=s };

            int TotalSec = clock.ToSecond();
            Console.WriteLine("Всего секунд {0}",TotalSec);
            Console.ReadKey();
        }
        
    }
}
