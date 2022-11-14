using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.nhap();
            nv.xuat();

            Console.WriteLine("--------------");
            KHACHHANG kh = new KHACHHANG();
            kh.nhap();
            kh.xuat();

            Console.ReadLine();
        }
    }
}
