using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class SinhVienIT : SinhVienPoly
    {
        public double diemJava;
        public double diemHtml;
        public double diemCss;

        public SinhVienIT(string hoTen, string nganh, double diemJava, double diemHtml, double diemCss) : base(hoTen, nganh)
        {
            this.diemJava = diemJava;
            this.diemHtml = diemHtml;
            this.diemCss = diemCss;
        }

        public override double GetDiem()
        {
            return (2 * diemJava + diemHtml + diemCss) / 4;
        }
    }
}
