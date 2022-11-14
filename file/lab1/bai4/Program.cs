using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
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
            candelta = Math.Sqrt(delta);

            Console.WriteLine("delta: " + delta);
            Console.WriteLine("can delta: " + candelta);
            Console.Read();

        }
    }
}
