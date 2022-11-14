using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList ds = new BookList();
            ds.nhap();
            ds.xuat();
            Console.WriteLine("--Sap xep theo sort--");
            ds.nhap();
            ds.xuat();
            Console.WriteLine("--Sap xep--");
            ds.nhap();
            ds.xuat();

            Console.Read();
        }
    }
}
