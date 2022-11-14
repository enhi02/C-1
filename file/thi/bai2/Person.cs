using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Person
    {
        public string ID;
        public string Ten;
        public int NamSinh;

        public void nhap()
        {
            Console.Write("Nhap ID:");
            ID = Console.ReadLine();

            Console.Write("Nhap Ten: ");
            Ten = Console.ReadLine();

            Console.Write("Nhap Nam Sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("id:" + ID);
            Console.WriteLine("ten:" + Ten);
            Console.WriteLine("nam sinh: " + NamSinh);
        }
    }
}

