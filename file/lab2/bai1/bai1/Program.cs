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
            double a, b, ketqua;
            Console.WriteLine("Phuong trinh bac nhat ax+b=0 ");
            Console.Write("Xin moi nhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap he so b: ");
            b = double.Parse(Console.ReadLine());
            if (a==0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                ketqua = (-b / a);
                Console.WriteLine("Phuong trinh co nghiem la: "+ ketqua);
            }
            Console.ReadKey();
        }
    }
}
