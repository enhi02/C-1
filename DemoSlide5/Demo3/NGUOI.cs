using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class NGUOI
    {
        // khai bao cac thuoc tinh
        public string ten;
        public string diachi;
        public string email;
        public string sodt;
        
        // nhap thong tin
        public virtual void nhap()
        {
            Console.Write("Ho ten: ");
            this.ten = Console.ReadLine();
            Console.Write("Dia chi: ");
            this.diachi = Console.ReadLine();
            Console.Write("Email: ");
            this.email = Console.ReadLine();
            Console.Write("So DT: ");
            this.sodt = Console.ReadLine();
        }
        //xuat thong tin
        public virtual void xuat()
        {
            Console.WriteLine("Ho ten: " + ten);
            Console.WriteLine("Dia chi: " + diachi);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("So DT: " + sodt);
        }
    }
}


