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
            sanpham sp1 = new sanpham("banh qui", 100, 15);
            sanpham sp2 = new sanpham("sua", 100, 50);
            sp1.nhap();
            sp2.nhap();
            sp1.xuat();
            sp2.xuat();
            Console.ReadKey();
        }
    }
}
