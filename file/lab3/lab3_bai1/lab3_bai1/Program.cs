using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so phan tu:");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            ArrayList b = new ArrayList();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "]=");
                int so = int.Parse(Console.ReadLine());
                a[i] = so;
                b.Add(so);
            }
            Console.WriteLine("\n ArrayList:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Array.Sort(a);
            b.Sort();
            Console.WriteLine("Sau khi dung arraylist sap xep:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[0])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("\n Min:" + min);
            int count = 0;
            double sum = 0, tb = 0;
            foreach (int x in a)
            {
                if (x % 3 == 0)
                {
                    sum = sum + x;
                    count++;
                }
            }
            tb = sum / count;
            Console.WriteLine("Trung binh cac phan tu chia het cho 3: " + tb);

            Console.ReadKey();
        }
    }
}
