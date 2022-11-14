using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class person
    {
        public string ID { get; set; }

        public string Ten { get; set; }

        public int NamSinh { get; set; }

        public void nhap()
        {
            int n;
            Console.WriteLine("Nhap vao so luong :");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ID:");
                ID = Console.ReadLine();

                Console.Write("Nhap Ten: ");
                Ten = Console.ReadLine();

                Console.Write("Nhap Nam Sinh: ");
                NamSinh = int.Parse(Console.ReadLine());
            }
        }
       
    }
 }

