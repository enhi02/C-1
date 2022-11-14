using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment
{
    class HocVien
    {

        public string MSSV { get; set; }
        string ten { get; set; }
        public double diem { get; set; }
        string email { get; set; }
        string hocLuc { get; set; }

        public HocVien(string ten, double diem, string email, string MSSV)
        {
            this.MSSV = MSSV;
            this.ten = ten;
            this.diem = diem;
            this.email = email;
        }

        public HocVien()
        {

        }
        public string getHocLuc()
        {
            string hocLuc = "yeu";
            if (this.diem >= 9)
            {
                hocLuc = "xuat sac";
            } else if (this.diem >= 7.5)
            {
                hocLuc = "gioi";
            } else if (this.diem >= 6.5)
            {
                hocLuc = "kha";
            }
            else if(this.diem >= 5)
            {
                hocLuc = "trung binh";
            }
            return hocLuc;
        }
        public void nhap()
        {
            Console.Write("nhap vao MSSV: ");
            this.MSSV = Console.ReadLine();

            Console.Write("nhap vao ten: ");
            this.ten = Console.ReadLine();

            Console.Write("nhap vao diem: ");
            this.diem = double.Parse(Console.ReadLine());

            Console.Write("nhap vao email: ");
            this.email = Console.ReadLine();
        }
        public void xuat()
        {
            Console.Write("TT\tMSSV\tTen\tDiem\temail\tHoc luc\n");
            Console.Write("\t{4}\t{0}\t{1}\t{2}\t{3}\n", this.ten, this.diem, this.email, getHocLuc(), this.MSSV);

        }

    }
}
