using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            sanPham sp1 = new sanPham();
            sanPham sp2 = new sanPham();
            sp1.nhap();
            sp2.nhap();
            sp1.xuat();
            sp2.xuat();
            Console.ReadKey();
        }
    }
}
