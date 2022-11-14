using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, candelta;
            Console.WriteLine("Nhap gia tri a: ");
            string sa = Console.ReadLine();
            a = double.Parse(sa);
            Console.WriteLine("Nhap gia tri b: ");
            string sb = Console.ReadLine();
            b = double.Parse(sb);
            Console.WriteLine("Nhap gia tri c: ");
            string sc = Console.ReadLine();
            c = double.Parse(sc);

            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem phan biet: ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep: ");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else
                Console.WriteLine("Phuong trinh vo nghiem");
            Console.ReadKey();
        }
    }
}
