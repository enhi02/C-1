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
            Console.WriteLine("nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int tong = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("phan tu: " + i);
                arr[i] = int.Parse(Console.ReadLine());
                tong += arr[i];
            }

            Console.WriteLine("tong cua mang la: " + tong);
            Console.ReadKey();
        }
    }
}
