using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int n, Chon;
            do
            {

                Console.Write("0. Exit: ");
                Console.Write("-----MENU-----\n");
                Console.Write("1. Nhap danh sach hoc vien\n");
                Console.Write("2. Xuat danh sach hoc vien\n");
                Console.Write("3. Tim kiem hoc vien theo khoang diem\n");
                Console.Write("4. Tim kiem hoc vien theo hoc luc\n");
                Console.Write("5. Tim kiem hoc vien theo ma so va update\n");
                Console.Write("6. Sap xep hoc vien theo diem\n");
                Console.Write("7. Xuat 5 hoc vien co diem cao nhat\n");
                Console.Write("8. Tinh diem trung binh cua lop\n");
                Console.Write("9. Xuat DSHV co diem tren diem TB cua lop\n");
                Console.Write("10. Tong hop so hoc vien hoc luc\n");
                Console.Write("Chon: ");
                Chon=int.Parse(Console.ReadLine());
                switch (Chon)
                {                  
                    case 1: yeucau1(list); break;//goi code yeu cau 1
                    case 2: yeucau2(list); break;//goi code yeu cau 2
                    case 3: yeucau3(list); break;//goi code yeu cau 3
                    case 4: yeucau4(list); break;//goi code yeu cau 4
                    case 5: yeucau5(list); break;//goi code yeu cau 5
                    case 6: yeucau6(list); break;//goi code yeu cau 6
                    case 7: yeucau6(list); break;//goi code yeu cau 7
                    case 8: Console.Write("Yeu cau 8\n"); break;//goi code yeu cau 8
                    case 9: Console.Write("Yeu cau 9\n"); break;//goi code yeu cau 9
                    case 10: Console.Write("Yeu cau 10\n"); break;//goi code yeu cau 10
                    case 0: Console.Write("Bye Bye!"); break;//exit
                    default: Console.Write("Chon tu 0 -> 10\n"); break;
                }
            } while (Chon != 0);           
        }
        public static void yeucau1(ArrayList list)
        {
            char chon;
            do
            {
                HocVien hv = new HocVien();
                hv.nhap();
                list.Add(hv);
                Console.WriteLine("Ban co muon nhap tiep khong(y or n)?: ");
                chon = char.Parse(Console.ReadLine());
            } while (chon == 'y' || chon == 'Y');
        }
        public static void yeucau2(ArrayList list)
        {
            foreach (HocVien hv in list)
            {
                hv.xuat();
            }    
        }
       public static void yeucau3(ArrayList list)
        {
            Console.WriteLine("Diem min: ");
            float min = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem max: ");
            float max = float.Parse(Console.ReadLine());

            foreach (HocVien hv in list)
            {
                if (hv.diem >= min && hv.diem <= max) 

                hv.xuat();
            }               
        }
        public static void yeucau4(ArrayList list)
        {
            Console.WriteLine("Hoc luc can tim: ");
            string x = Console.ReadLine();
            Console.WriteLine("TT\tMSSV\tTen\tDiem\temail\tHoc luc\n");
            foreach (HocVien hv in list)
            {
                if (x == hv.xeploai())
                    hv.xuat();
            }
        }
        public static void yeucau5(ArrayList list)
        {
            Console.WriteLine("Moi ban nhap ma so sinh vien: ");
            string x = Console.ReadLine();
            foreach (HocVien hv in list)
            {
                if (x == hv.mssv)
                {
                    hv.xuat();
                    hv.nhap();
                }
            }
        }
        public static void yeucau6(ArrayList list)
        {
            list.Sort((a, b) => (int)(b.diem - a.diem));
            foreach (HocVien hv in list)
            {
                hv.xuat();
            }
        }
        public static void yeucau7(ArrayList list)
        {
            list.Sort((a, b) => (int)(b.diem - a.diem));

            for (int i = 0; i < 5 && i < list.Count; i++)
            {
                list[i].xuat();
            }
        }

