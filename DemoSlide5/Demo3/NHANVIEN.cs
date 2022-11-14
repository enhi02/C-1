using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class NHANVIEN:NGUOI
    {
        public String bangcap;
     
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Bang cap: " + bangcap);
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Bang cap: ");
            this.bangcap = Console.ReadLine();
        }
    }
}
