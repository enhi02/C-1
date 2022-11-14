using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class HinhVuong : HinhChuNhat
    {
        public double canh;
        public HinhVuong(double canh) : base(canh, canh)
        {
            this.canh = canh;
        }


        public override void Xuat()
        {
            Console.WriteLine("Canh: " + canh);
            Console.WriteLine("Chu vi: " + GetChuVi());
            Console.WriteLine("Dien tich: " + GetDienTich());
        }
    }
}
