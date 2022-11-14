using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Xin moi nhap so Sinh vien :");
            n = int.Parse(Console.ReadLine());
            string[] hoTen = new string[n];
            float[] diem = new float[n];

            for (int i = 0; i < hoTen.Length; i++)
            {
                Console.WriteLine("NHap SV thu" + (i + 1));
                Console.Write("\nnhap ho ten: ");
                hoTen[i] = Console.ReadLine();

                Console.Write("nhap vao diem: ");
                diem[i] = float.Parse(Console.ReadLine());
            }
            string[] hocLuc = new string[n];
            Console.WriteLine("-----------------Danh sach sinh vien vua nhap-------------------");
            Console.WriteLine("TT\thoten\tdiem\thocLuc");
            //float d = diem[i];
            for (int i = 0; i < hoTen.Length; i++)
            {
                Console.Write((i + 1) + "\t" + hoTen[i] + "\t" + diem[i]);
                if (diem[i] >= 9)//d>=9
                {
                    hocLuc[i] = "xuat sac";
                }
                else if (diem[i] >= 7.5)
                {
                    hocLuc[i] = "Gioi";
                }
                else if (diem[i] >= 6.5)
                {
                    hocLuc[i] = "Kha";
                }
                else if (diem[i] >= 5 && diem[i] < 6.5)
                {
                    hocLuc[i] = "Trung binh";
                }
                else
                {
                    hocLuc[i] = "Yeu";
                }
                Console.WriteLine("\t" + hocLuc);
            }
            for (int i = 0; i < diem.Length - 1; i++)
            {
                for (int j = i + 1; j < diem.Length; j++)
                {
                    float temp = diem[i];
                    diem[i] = diem[j];
                    diem[j] = temp;

                    string stemp = hoTen[i];
                    hoTen[i] = hoTen[j];
                    hoTen[j] = stemp;
                }
            }
            Console.WriteLine("-----------------Danh sach sinh vien vua nhap(duoc sap xep )-------------------");
            Console.WriteLine("TT\thoten\tdiem\thocLuc");
            for (int i = 0; i < hoTen.Length; i++)
            {
                Console.Write((i + 1) + "\t" + hoTen[i] + "\t" + diem[i]);
                if (diem[i] >= 9)//d>=9
                {
                    hocLuc[i] = "xuat sac";
                }
                else if (diem[i] >= 7.5)
                {
                    hocLuc[i] = "Gioi";
                }
                else if (diem[i] >= 6.5)
                {
                    hocLuc[i] = "Kha";
                }
                else if (diem[i] >= 5 && diem[i] < 6.5)
                {
                    hocLuc[i] = "Trung binh";
                }
                else
                {
                    hocLuc[i] = "Yeu";
                }
                Console.WriteLine("\t" + hocLuc);

            }
            Console.ReadKey();
        }
    }
}
