using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Nhap a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = int.Parse(Console.ReadLine());
            c = a / b;
            Console.Write("C= " + a + "/" + b + " = " + c);
            Console.Write("\nSau phep chia !");
            //....................................
            //int a, b, c;
            //try
            //{
            //    Console.Write("Nhap a= ");
            //    a = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap b= ");
            //    b = int.Parse(Console.ReadLine());
            //    c = a / b;
            //    Console.Write("C= " + a + "/" + b + " = " + c);
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e);
            //}
            //Console.Write("\nSau phep chia !");
            //..................................
            //int a, b, c;
            //try
            //{
            //    Console.Write("Nhap a= ");
            //    a = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap b= ");
            //    b = int.Parse(Console.ReadLine());
            //    c = a / b;
            //    Console.WriteLine("C= " + a + "/" + b + " = " + c);
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e);
            //}
            //finally
            //{
            //    Console.WriteLine("\nFinal: ");
            //}
            //Console.Write("Sau phep chia !");

            Console.ReadLine();
        }
    }
}
