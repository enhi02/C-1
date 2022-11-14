using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class bai3
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            Person per2 = new Person();

            Console.WriteLine("nhap per1: ");
            per1.nhap();
            Console.WriteLine("nhap per2: ");
            per2.nhap();

            Console.WriteLine("xuat per1: ");
            per1.xuat();
            Console.WriteLine("xuat per2: ");
            per2.xuat();

        }
    }
}
