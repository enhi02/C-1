using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class student
    {
        public string hoTen;
        public double DiemTB;

        public void nhap()
        {
            Console.Write("ho Ten: ");
            this.hoTen = Console.ReadLine();
            Console.Write("diem: ");
            this.DiemTB = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("ho ten: " + this.hoTen);
            Console.WriteLine("DiemTB: " + this.DiemTB);
            Console.WriteLine("Xep loai: " + xeploai());
        } 
        public student(string hoTen, double diemTB)
        {
            this.hoTen = hoTen;
            this.DiemTB = DiemTB;
        }
        public student()
        {
            this.hoTen = "";
            this.DiemTB = 0;
        }
        public String xeploai()
        {
            String hocluc = "";
            if (DiemTB >= 9)
            {
                hocluc = "Xuat Sac";
            }
            else if (DiemTB >= 7.5 && DiemTB < 9)
            {
                hocluc = "Gioi";
            }
            else if (DiemTB >= 6.5 && DiemTB < 7.5)
            {
                hocluc = "Kha";
            }
            else if (DiemTB >= 5 && DiemTB < 6.5)
            {
                hocluc = "Trung binh";
            }                
            else
            {
                hocluc = "Yeu";
            }
            return hocluc;
            Console.Read();
        }    

    }
}
