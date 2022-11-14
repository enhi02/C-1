using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoTen;
            string nganh;
            double diemJava, diemHtml, diemCss;
            double diemMarketing, diemSales;

            Console.WriteLine("Sinh Vien IT");

            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nganh: ");
            nganh = Console.ReadLine();

            Console.WriteLine("Diem Java: ");
            diemJava = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diem Html: ");
            diemHtml = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diem Css: ");
            diemCss = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------Thong tin -----------------------");
            SinhVienIT sinhVienIT = new SinhVienIT(hoTen, nganh, diemJava, diemHtml, diemCss);
            sinhVienIT.Xuat();

            Console.WriteLine("\nSinh Vien Biz");

            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nganh: ");
            nganh = Console.ReadLine();

            Console.WriteLine("Diem Marketing: ");
            diemMarketing = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diem Sales: ");
            diemSales = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------Thong tin -----------------------");
            SinhVienBiz sinhVienBiz = new SinhVienBiz(hoTen, nganh, diemMarketing, diemSales);
            sinhVienBiz.Xuat();

            Console.ReadKey();
        }
    }
}
