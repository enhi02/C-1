using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1: Nhap so ");
                Console.WriteLine("2: Hien thi cac so nguyen duong");
                Console.WriteLine("3: Thoat");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            nhapSo();
                            break;
                        }
                    case 2:
                        {
                            hienThi();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("thoat");
                            break;
                        }
                    default:
                        Console.WriteLine("chon sai, vui long chon lai");
                        break;
                }
            } while (choose != 3);
            Console.ReadLine();
        }
        public static Number sn1 = new Number();
        public static void nhapSo()
        {
            sn1.input();
        }

        public static void hienThi()
        {
            sn1.output();
        }
    }
}
