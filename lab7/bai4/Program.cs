using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1: Nhap thong tin SV");
                Console.WriteLine("2: Hien thi thong tin SV");
                Console.WriteLine("0: thoat");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        {
                            nhapThongTin();
                            break;
                        }
                    case 2:
                        {
                            hienThi();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("thoat");
                            break;
                        }
                    default:
                        Console.WriteLine("chon sai , vui long chon lai");
                        break;
                }
            } while (choose != 0);
            Console.ReadLine();
        }

        public static List<student> students = new List<student>();

        public static void nhapThongTin()
        {
            string a;
            do
            {
                student sv = new student();
                sv.input();
                students.Add(sv);
                Console.Write("nhap tiep (Y/N)");
                a = Console.ReadLine();
            } while (a == "y" || a == "Y");
        }

        public static void hienThi()
        {
            Console.WriteLine("-----THONG TIN SV------");
            Console.WriteLine("ID\tNam\tAGE");
            foreach(var SV in students)
            {
                SV.output();
            }
        }
    }
}
