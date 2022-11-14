using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class HinhVuong : ChuNhat
    {
        public HinhVuong(double canh): base(canh, canh)
        {

        }
        public override void xuat()
        {
            Console.WriteLine("\nCanh: " + dai);
            Console.WriteLine("\nDien tich: " + getDientich());
            Console.WriteLine("\nChu vi: " + getChuvi());
        }
    }
}
