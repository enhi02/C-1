using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_nang_cao
{
    class sanpham
    {
        public string ten;
        public double gia;
        public double giamGia;
        public void nhap()
        {
            Console.Write("nhap vao ten: ");
            this.ten = Console.ReadLine();
            Console.Write("nhap vao don gia: ");
            this.gia = double.Parse(Console.ReadLine());
            Console.Write("nhap vao giam gia: ");
            this.giamGia = double.Parse(Console.ReadLine());
        }
        public double thueNhapKhau()
        {
            double thue = gia * 10 / 100;
            return thue;
        }
        public void xuat()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("ten: " + this.ten);
            Console.WriteLine("gia: " + this.gia);
            Console.WriteLine("giam gia: " + this.giamGia);
            Console.WriteLine("thue nhap khau: " + thueNhapKhau());
        }
        public sanpham(string tenSp, double donGia, double giamGia)
        {
            this.ten = tenSp;
            this.gia = donGia;
            this.giamGia = giamGia;
        }
        public sanpham()
        {
            this.ten = "";
            this.gia = 0;

        }
        private double getthueNhapKhau()
        {
            return gia * 0.1;
        }
        
    }
}
