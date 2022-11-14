using System;
using System.Collections;
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
            //int n;
            //Console.Write("nhap vao so phan tu: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] mangSo = new int[n];
            //for (int i = 0; i < mangSo.Length; i++)
            //{
            //    Console.Write("nhap phan thu thu {0}: ", i);
            //    string st = Console.ReadLine();
            //    mangSo[i] = int.Parse(st);
            //}
            ArrayList mangSo = new ArrayList();
            int x = 0;
            do
            {
                Console.Write("Nhap so (0 to exit): ");
                x = int.Parse(Console.ReadLine());
                mangSo.Add(x);
            } while (x != 0);
            Console.WriteLine("cac phan tu cua mang: ");
            foreach (int i in mangSo)
            {
                Console.Write(" " + i);
            }
            mangSo.Sort();
            Console.WriteLine("\ncac phan tu cua mang sau khi sap xep: ");
            foreach (int i in mangSo)
            {
                Console.Write(" " + i);
            }
            int min = (int)mangSo[0];
            for(int i=1;i<mangSo.Count;i++)
            {
                min = Math.Min(min, (int)mangSo[i]);
            }
            Console.Write($"\ngia tri nho nhat = {min}");
            //tinh trung bình tổng
            int tong=0,count=0;
            foreach (int i in mangSo)
            {
                if (i % 3 == 0)
                {
                    tong += i;
                    count++;
                }
            }
            float tb =(float) tong / count;
            Console.Write("\ntong = " + tong);
            Console.Write("\ntrung binh tong cac so chia het cho 3 cua mang la: " + tb);
            Console.ReadKey();
        }
    }
}
