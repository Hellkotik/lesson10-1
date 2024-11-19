using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les10_pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы");
            int grad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите угловые минуты");
            int gradMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите угловые секунды");
            int gradSec = Convert.ToInt32(Console.ReadLine());
            Rad rad=new Rad(grad, gradMin, gradSec);
            double radians=rad.ToRad();
            Console.WriteLine("Ваши градусы в радианах {0}",radians);
            Console.ReadKey();

        }
    }
}
