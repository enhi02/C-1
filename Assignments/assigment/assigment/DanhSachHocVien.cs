using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment
{
    class DanhSachHocVien
    {
        private List<HocVien> list = new List<HocVien>();

        public void Nhap()
        {
            char chon;
            do
            {
                HocVien hv = new HocVien();
                Console.Write("nhap thong tinh hoc vien\n");
                hv.nhap();

                list.Add(hv);

                Console.Write("Ban co nhap nua ko (y or n)");
                chon = char.Parse(Console.ReadLine());

            } while (chon == 'y' || chon == 'Y');
        }

        public void Xuat()
        {
            foreach (HocVien hv in list)
            {
                hv.xuat();
            }
        }

        public void TimTheoKhoangDIem()
        {
            Console.Write("nhap vao diem min; ");
            float min = float.Parse(Console.ReadLine());
            Console.Write("nhap vao diem max; ");
            float max = float.Parse(Console.ReadLine());
 
            foreach (HocVien hv in list)
            {
                if (hv.diem >= min && hv.diem <= max)
                    hv.xuat();
            }
        }

        public void TimTheoHocLuc()
        {
            Console.Write("nhap vao hoc luc can tiem: ");
            string hocLuc = Console.ReadLine();

            foreach (var hv in list)
            {
                if (hv.getHocLuc().Equals(hocLuc, StringComparison.OrdinalIgnoreCase))
                {
                    hv.xuat();
                }
            }
        }

        public void TimVaCapNhatTheoMa()
        {
            Console.Write("nhap vao MSSV can tim: ");
            string ma = Console.ReadLine();
            foreach (var hv in list)
            {
                {
                    if (ma == hv.MSSV)
                    {
                        hv.xuat();
                        hv.nhap();
                    }
                }
            }
            
        }

        public void SapXepTheoDiem()
        {
            list.Sort((a, b) => (int)(b.diem - a.diem));
            foreach (HocVien hv in list)
            {
                hv.xuat();
            }
        }

        public void XuatTop5()
        {
            list.Sort((a, b) => (int)(b.diem - a.diem));

            for (int i = 0; i < 5 && i<list.Count; i++)
            {
                list[i].xuat();
            }
        }

        public void DiemTrungbinhHV()
        {
            double tong=0;
            int count = 0;
            foreach (HocVien hv in list)
            {
                tong += hv.diem;
                count++;
            }
            float diemTB = (float)tong / count;
            Console.WriteLine("diem trung binh của tat ca hoc vien : " + diemTB);
        }

        public void XuatHVTrenTB()
        {
            double tong = 0;
            int count = 0;
            foreach (HocVien hv in list)
            {
                tong += hv.diem;
                count++;
            }
            float diemTB = (float)tong / count;

            foreach (HocVien hv in list)
            {
                if (hv.diem >= diemTB)
                {
                    hv.xuat();
                }
            }
        }

        public void TongHVTheoHocLuc()
        {
            Console.WriteLine("------HOC SINH XUAT SAC------");
            foreach (HocVien hv in list)
            {
                if (hv.diem >= 9)
                {
                    hv.xuat();
                }
            }
            Console.WriteLine("--------HOC SINH GIOI--------");
            foreach (HocVien hv in list)
            {
                if (hv.diem >= 7.5)
                {
                    hv.xuat();
                }
            }
            Console.WriteLine("---------HOC SINH KHA---------");
            foreach (HocVien hv in list)
            {
                if (hv.diem >= 6.5 && hv.diem <7.5)
                {
                    hv.xuat();
                }
            }
            Console.WriteLine("------HOC SINH TRUNG BINH--------");
            foreach (HocVien hv in list)
            {
                if (hv.diem >= 5 && hv.diem <6.5)
                {
                    hv.xuat();
                }
            }
            Console.WriteLine("---------HOC SINH YEU---------");
            foreach (HocVien hv in list)
            {
                if (hv.diem < 5)
                {
                    hv.xuat();
                }
            }
        }
    }
}
