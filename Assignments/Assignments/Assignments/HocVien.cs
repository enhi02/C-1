using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class HocVien
    {
        public string mssv { get; set; }
        public string hoten { get; set; }

        public string email { get; set; }
        public double diem { get; set; }
        public string hocluc { get; set; }
        public void nhap()
        {
            Console.Write(" Ma so sv:");
            mssv = Console.ReadLine();

            Console.Write("Ho Ten sv:");
            hoten = Console.ReadLine();

            Console.Write("email:");
            email = Console.ReadLine();

            Console.Write("Diem:");
            diem = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine(mssv + "\t" + hoten + "\t" + email + "\t" + diem + "\t" + xeploai());
        }
        public HocVien()
        {
            this.mssv = "";
            this.hoten = "";
            this.email = "";
            this.diem = 0;
            this.hocluc = "";
        }
        public string xeploai()
        {
            if (diem >= 9)
            {
                hocluc = "xuat sac";
            }
            else if (diem >= 7.5)
            {
                hocluc = "Gioi";
            }
            else if (diem >= 6.5)
            {
                hocluc = "Kha";
            }
            else if (diem >= 5 && diem < 6.5)
            {
                hocluc = "Trung binh";
            }
            else
            {
                hocluc = "Yeu";
            }
            return hocluc;
        }
    }
}

