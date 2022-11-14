using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class SinhVien
    {
        public string hoTen;
        public double diem;
        public string nganh;
        public string diaChi;

        public SinhVien(string hoTen, double diem,string nganh, string diaChi)
        {
            this.hoTen = hoTen;
            this.diem = diem;
            this.nganh = nganh;
            this.diaChi = diaChi;
        }

        public string GetHocLuc()
        {
            if (diem >= 9)
            {
                return "Xuat sac";
            }
            else if (diem >= 7.5)
            {
                return "Gioi";
            }
            else if (diem >= 6.5)
            {
                return "Kha";
            }
            else if (diem >= 5)
            {
                return "Trung binh";
            }
            else // diem() < 5
            {
                return "Yeu";
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"{hoTen}\t{diem}\t{diaChi}\t{nganh}\t{GetHocLuc()}");
        }
    }
}
