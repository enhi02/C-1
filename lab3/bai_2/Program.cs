using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hoTen = new string[5];
            float[] diem = new float[5];

            for (int i=0;i< hoTen.Length; i++)
            {
                Console.Write("nhap ho ten: ");
                hoTen[i] = Console.ReadLine();

                Console.Write("nhap vao diem: ");
                string st = Console.ReadLine();
                diem[i] = float.Parse(st);
            }
            string[] hocLuc = new string[5];
            for (int i= 0;i < hoTen.Length;i++)
            {
                if (diem[i] >= 9)
                {
                    hocLuc[i] = "xuat sac";
                }
                else if (diem[i] >= 7.5)
                {
                    hocLuc[i] = "goi";
                }
                else if (diem[i] >= 6.5)
                {
                    hocLuc[i] = "KHA";
                }
                else if (diem[i] >= 5 && diem[i] < 6.5)
                {
                    hocLuc[i] = "trung binh";
                }
                else
                    hocLuc[i] = "yeu";
            }
            Console.Write("danh sach sinh vien chua xep sep\n");
            for(int i=0;i<hoTen.Length;i++)
            {
                Console.Write("ho ten: {0} | diem: {1} | hoc luc: {2}\n", hoTen[i], diem[i], hocLuc[i]);
            }
            for(int i=0;i<diem.Length;i++)
            {
                for(int j=0;j<diem.Length;j++)
                {
                    if (diem[i]<diem[j])
                    {
                        string temp = hoTen[i];
                        hoTen[i] = hoTen[j];
                        hoTen[j] = temp;
                        float temps = diem[i];
                        diem[i] = diem[j];
                        diem[j] = temps;
                    }   
                }   
            }
            Console.Write("danh sach sinh vien sau khi xap sep\n");
            for (int i = 0; i < hoTen.Length; i++)
            {
                if (diem[i] >= 9)
                {
                    hocLuc[i] = "xuat sac";
                }
                else if (diem[i] >= 7.5)
                {
                    hocLuc[i] = "goi";
                }
                else if (diem[i] >= 6.5)
                {
                    hocLuc[i] = "KHA";
                }
                else if (diem[i] >= 5 && diem[i] < 6.5)
                {
                    hocLuc[i] = "trung binh";
                }
                else
                    hocLuc[i] = "yeu";
            }
            for (int i = 0; i < hoTen.Length; i++)
            {
                Console.Write("ho ten: {0} | diem: {1} | hoc luc: {2}\n", hoTen[i], diem[i], hocLuc[i]);
            }

            Console.ReadKey();
        }
    }
}
