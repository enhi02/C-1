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
            bool isExit = false;
            int chon;
            do
            {
                Console.WriteLine("\n------------------Menu-----------------");
                Console.WriteLine("1. Nhap");
                Console.WriteLine("2. Xuat");
                Console.WriteLine("3. Sv Gioi");
                Console.WriteLine("4. Sap xep");
                Console.WriteLine("5. Thoat");

                chon = Chon();
                Console.WriteLine();
                switch (chon)
                {
                    case 1:
                        Nhap();
                        break;
                    case 2:
                        Xuat();
                        break;
                    case 3:
                        DsSinhVienGioi();
                        break;
                    case 4:
                        Sapxep();
                        break;
                    case 5:
                        Console.WriteLine("Thoat chuong trinh");
                        isExit = true;
                        break;
                }
            } while (!isExit);

            if (chon != 5)
            {
                Console.Clear();
                Console.ReadKey();
                Console.WriteLine("Nhan phim bat ki de quay lai menu");
            }

            Console.ReadKey();
        }

        //----------Khoi tao mang Sinh Vien------------
        static List<SinhVien> dsSinhVien = new List<SinhVien>();

        //----------Chon chuc nang--------------------
        static int Chon()
        {
            int chon = 0;
            bool isHopLe;

            do
            {
                isHopLe = true;
                try
                {
                    Console.Write("Nhap lua chon: ");
                    chon = Convert.ToInt32(Console.ReadLine());

                    if (chon < 1 || chon > 5)
                    {
                        isHopLe = false;
                        Console.WriteLine("Vui long chon chuc nang tu 1-5");
                    }
                }
                catch (Exception)
                {
                    isHopLe = false;
                    Console.WriteLine("Vui long nhap so"); 
                }
            } while (!isHopLe);

            return chon;
        }

        //----------Nhap-----------------------------
        static void Nhap()
        {
            string nhapTiep;

            do
            {
                dsSinhVien.Add(new SinhVien(HoTen(), Diem(),Nganh(), DiaChi()));

                Console.Write("Nhap 1 de nhap tiep hoac nhap bat ki de thoat: ");
                nhapTiep = Console.ReadLine();
                Console.WriteLine("-");
            } while (nhapTiep == "1");
        }
        static string HoTen()
        {
            string hoTen;
            bool isHopLe;

            do
            {
                isHopLe = true;

                Console.Write("Ten: ");
                hoTen = Console.ReadLine();

                if (hoTen.Length < 0)
                {
                    isHopLe = false;
                    Console.WriteLine("Vui long nhap ten co do dai > 0");
                }
            } while (!isHopLe);

            return hoTen;
        }
        static double Diem()
        {
            double diem = 0;
            bool isHopLe;

            do
            {
                isHopLe = true;

                try
                {
                    Console.Write("Diem: ");
                    diem = Convert.ToDouble(Console.ReadLine());

                    if (diem < 0 || diem > 10)
                    {
                        isHopLe = false;
                        Console.WriteLine("Vui long nhap diem tu 0-10");
                    }
                }
                catch (Exception)
                {
                    isHopLe = false;
                    Console.WriteLine("Vui long nhap so");
                }
            } while (!isHopLe);

            return diem;
        }
        static string Nganh()
        {
            string nganh;
            Console.Write("Nganh: ");
            nganh = Console.ReadLine();

            return nganh;
        }
        static string DiaChi()
        {
            string diaChi;
            bool isHopLe;

            do
            {
                isHopLe = true;

                Console.Write("Dia chi: ");
                diaChi = Console.ReadLine();

                if (diaChi.Length < 0)
                {
                    isHopLe = false;
                    Console.WriteLine("Vui long nhap dia chi co do dai > 0");
                }
            } while (!isHopLe);

            return diaChi;
        }

        //----------Xuat------------------------------
        static void Xuat()
        {
            Console.WriteLine("\t\tDS Sinh Vien");
            foreach (SinhVien sinhVien in dsSinhVien)
            {
                sinhVien.Xuat();
            }
        }

        //----------Sinh vien hoc luc gioi------------
        static void DsSinhVienGioi()
        {
            Console.WriteLine("\n\t\tDS Sinh Vien GIOI");
            foreach (SinhVien sinhVien in dsSinhVien)
            {
                if (sinhVien.diem >= 7.5 && sinhVien.diem < 9)
                {
                    sinhVien.Xuat();
                }
            }
        }

        //----------Sap xep sinh vien theo diem------
        static void Sapxep()
        {
            int chon;

            Console.WriteLine("1. Sap xep theo diem tang dan");
            Console.WriteLine("2. Sap xep theo diem giam dan");

            chon = ChonSapXep();

            switch (chon)
            {
                case 1:
                    DiemTangDan();
                    break;
                case 2:
                    DiemGiamDan();
                    break;
            }

            Xuat();
        }
        static int ChonSapXep()
        {
            int chon = 0;
            bool isHopLe;

            do
            {
                isHopLe = true;
                try
                {
                    Console.Write("Nhap lua chon: ");
                    chon = Convert.ToInt32(Console.ReadLine());

                    if (chon < 1 || chon > 2)
                    {
                        isHopLe = false;
                        Console.WriteLine("Vui long chon chuc nang tu 1-2");
                    }
                }
                catch (Exception)
                {
                    isHopLe = false;
                    Console.WriteLine("Vui long nhap so");
                }
            } while (!isHopLe);

            return chon;
        }
        static void DiemTangDan()
        {
            Console.WriteLine("DS Sinh vien theo diem tang dan");

            for (int i = 0; i < dsSinhVien.Count - 1; i++)
            {
                for (int j = i + 1; j < dsSinhVien.Count; j++)
                {
                    if (dsSinhVien[i].diem > dsSinhVien[j].diem)
                    {
                        SinhVien sinhVienTam = dsSinhVien[i];
                        dsSinhVien[i] = dsSinhVien[j];
                        dsSinhVien[j] = sinhVienTam;
                    }
                }
            }
        }
        static void DiemGiamDan()
        {
            Console.WriteLine("DS Sinh vien theo diem giam dan");

            for (int i = 0; i < dsSinhVien.Count - 1; i++)
            {
                for (int j = i + 1; j < dsSinhVien.Count; j++)
                {
                    if (dsSinhVien[i].diem > dsSinhVien[j].diem)
                    {
                        SinhVien sinhVienTam = dsSinhVien[i];
                        dsSinhVien[i] = dsSinhVien[j];
                        dsSinhVien[j] = sinhVienTam;
                    }
                }
            }

            dsSinhVien.Reverse();
        }
    }
}
