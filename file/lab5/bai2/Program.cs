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
            Console.Write("Nhap ho ten SV: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nganh Hoc: ");
            string nganh = Console.ReadLine();

            Console.Write("Nhap Diem: ");
            double diem = double.Parse(Console.ReadLine());

            Console.Write("Hoc Luc: ");
            string hocLuc = Console.ReadLine();

            SinhVienPoly sv = new SinhVienPoly(hoTen, nganh)
            sv.Xuat();

            Console.Read();
        }
    }
}
