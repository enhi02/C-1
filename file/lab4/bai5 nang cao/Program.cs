using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_nang_cao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong hang: ");
            n = int.Parse(Console.ReadLine());
            sanpham[] dssp = new sanpham[n];
           
            for (int i = 0; i < dssp.Length; i++)
            {
                sanpham sp = new sanpham();
                sp.nhap();
                dssp[i] = sp;
            }
            Console.WriteLine("Ten\tDonGia\tThue Nhap Khau");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < n; i++)
            {
                dssp[i].xuat();
            }
            Console.Read();
        }
    }
}
