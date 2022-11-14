using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment
{
    class programs
    {
        static void Main(string[] args)
        {
            DanhSachHocVien ds = new DanhSachHocVien();

            int chon;

            do
            {
                Console.Write("-------menu------\n");
                Console.Write("1: Nhap danh sach hoc vien\n");
                Console.Write("2: Xuat danh sach hoc vien\n");
                Console.Write("3: Tim kiem hoc vien theo khoang diem\n");
                Console.Write("4: Tim kiem hoc vien theo hoc luc\n");
                Console.Write("5: Tim kiem hoc vien theo ma so va update\n");
                Console.Write("6: Sap xep hoc vien theo diem\n");
                Console.Write("7: Xuat 5 HV co diem cao nhat\n");
                Console.Write("8: Tim diem trung binh cua lop\n");
                Console.Write("9: Xuat dshv co diem cao tren diem TB cua lop\n");
                Console.Write("10: Tong hop so hoc vien hoc luc\n");
                Console.Write("0 -> exit\n");
                Console.Write("Chon: ");
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (chon)
                {
                    case 1: yeucau1(ds); break;
                    case 2: yeucau2(ds); break;
                    case 3: yeucau3(ds); break;
                    case 4: yeucau4(ds); break;
                    case 5: yeucau5(ds); break;
                    case 6: yeucau6(ds); break;
                    case 7: yeucau7(ds); break;
                    case 8: yeucau8(ds); break;
                    case 9: yeucau9(ds); break;
                    case 10: yeucau10(ds); break;
                    case 0: Console.Write("bye"); break;
                    default: Console.Write("chon 0 ->10\n"); break;
                }
            } while (chon != 0);
        }



        public static void yeucau1(DanhSachHocVien ds)
        {
            ds.Nhap();
        }

        public static void yeucau2(DanhSachHocVien ds)
        {
            ds.Xuat();
        }

        public static void yeucau3(DanhSachHocVien ds)
        {
            ds.TimTheoKhoangDIem();
        }

        public static void yeucau4(DanhSachHocVien ds)
        {
            ds.TimTheoHocLuc();
        }

        public static void yeucau5(DanhSachHocVien ds)
        {
            ds.TimVaCapNhatTheoMa();
        }

        public static void yeucau6(DanhSachHocVien ds)
        {
            ds.SapXepTheoDiem();
        }

        public static void yeucau7(DanhSachHocVien ds)
        {
            ds.XuatTop5();
        }

        public static void yeucau8(DanhSachHocVien ds)
        {
            ds.DiemTrungbinhHV();
        }

        public static void yeucau9(DanhSachHocVien ds)
        {
            ds.XuatHVTrenTB();
        }

        public static void yeucau10(DanhSachHocVien ds)
        {
            ds.TongHVTheoHocLuc();
        }

    }
}
