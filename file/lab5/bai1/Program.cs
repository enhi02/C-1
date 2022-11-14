using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chieu dai: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("\nChieu rong: ");
            double rong = double.Parse(Console.ReadLine());
            Console.Write("\nCanh: ");
            double canh = double.Parse(Console.ReadLine());

            ChuNhat cn = new ChuNhat(dai, rong);                              
            cn.xuat();

            HinhVuong vu = new HinhVuong(canh);
            vu.xuat();

            Console.Read();
        }
    }
}
