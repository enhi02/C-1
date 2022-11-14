using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2va3
{
    class SinhVienBiz : SinhVienPoly
    {
        public double diemMarketing;
        public double diemSales;

        public SinhVienBiz(string hoTen, string nganh, double diemMarketing, double diemSales) : base(hoTen, nganh)
        {
            this.diemMarketing = diemMarketing;
            this.diemSales = diemSales;
        }

        public override double GetDiem()
        {
            return (2 * diemMarketing + diemSales) / 3;
        }
    }
}
