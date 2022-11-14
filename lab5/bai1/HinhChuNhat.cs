using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class HinhChuNhat
    {
        public double dai;
        public double rong;

        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double GetChuVi()
        {
            return (dai + rong) * 2;
        }

        public double GetDienTich()
        {
            return dai * rong;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Chieu rong: " + rong);
            Console.WriteLine("Chieu dai: " + dai);
            Console.WriteLine("Chu vi: " + GetChuVi());
            Console.WriteLine("Dien tich: " + GetDienTich());
        }
    }
}
