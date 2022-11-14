using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Toan t1 = new Toan();

            double a, b;
            Console.Write("Nhap vao so thu nhat: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            b = Convert.ToDouble(Console.ReadLine());

            Toantu Math = t1.Tong;
            Math += t1.Hieu;
            Math += t1.Tich;
            Math += t1.Thuong;
            Math(a, b);

            Console.ReadKey();
        }
    }
}
