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
            double dai, rong, canh;

            Console.WriteLine("Hinh chu nhat");
            Console.Write("Chieu dai: ");
            dai = Convert.ToDouble(Console.ReadLine());
             Console.Write("Chieu rong: ");
            rong = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("------Xuat--------");

            HinhChuNhat hinhChuNhat = new HinhChuNhat(dai, rong);
            hinhChuNhat.Xuat();

            Console.WriteLine("\nHinh Vuong");
            Console.Write("Canh: ");
            canh = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("------Xuat--------");

            HinhVuong hinhVuong = new HinhVuong(canh);
            hinhVuong.Xuat();


            Console.ReadKey();
        }
    }
}
