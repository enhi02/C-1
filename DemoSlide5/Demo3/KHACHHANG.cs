using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class KHACHHANG:NGUOI
    {
        public String loaikh;

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Loai KH: " + loaikh);
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Loai KH: ");
            this.loaikh = Console.ReadLine();
        }
    }
}
