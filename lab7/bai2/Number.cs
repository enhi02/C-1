using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public delegate void PrintDetails();
    class Number
    {
        public event PrintDetails Print;

        public void nhapSo()
        {
            PrintDetails Sn = this.input;
        }

        public void hienThi()
        {
            PrintDetails Sn = this.output;
            this.Print += Sn;
            this.Print();
            Sn();
        }

        public int a;

        ArrayList Sn = new ArrayList();

        public void input()
        {
            string choose;
            do
            {
                Console.Write("nhap so: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("Nhap a>0");
                    return;
                }
                Sn.Add(a);
                Console.Write("NHAP THEM (Y/N): ");
                choose = Console.ReadLine();
            } while (choose == "y" || choose == "y");


        }

        public void output()
        {
            Console.WriteLine("----------cac so nguyen---------");
            foreach(int item in Sn)
            {
                if (item >= 0)
                {
                    Console.WriteLine("{0}\t", item);
                }
            }
        }
    }
}
