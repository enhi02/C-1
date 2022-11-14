using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class ChuNhat
    {
        public double rong;
        public double dai;

        public ChuNhat(double rong, double dai)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double getChuvi()
        {
            
            return (dai+rong)*2;
        }
        public double getDientich()
        {
            
            return dai*rong;
        }
        public virtual void xuat()
        {
            Console.Write("\nChieu dai: " + dai);
            Console.Write("\nChieu rong: " + rong);
            Console.Write("\nDien tich: " + getDientich());
            Console.Write("\nChu vi: " + getChuvi());
        }
    }
}
