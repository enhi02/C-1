using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    abstract class SinhVienPoly
    {
        public string hoTen;
        public string nganh;

        protected SinhVienPoly(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
        }

        public abstract double GetDiem();

        public string GetHocLuc()
        {
            if (GetDiem() >= 9)
            {
                return "Xuat sac";
            }
            else if (GetDiem() >= 7.5)
            {
                return "Gioi";
            }
            else if (GetDiem() >= 6.5)
            {
                return "Kha";
            }
            else if (GetDiem() >= 5)
            {
                return "Trung binh";
            }
            else // GetDiem() < 5
            {
                return "Yeu";
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("Nganh: " + nganh);
            Console.WriteLine("Diem: " + GetDiem());
            Console.WriteLine("Hoc luc: " + GetHocLuc());
        }
    }
}