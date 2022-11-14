using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong, chuvi, dientich, canhnho;
            Console.WriteLine("Nhap chieu dai: ");
            string sdai = Console.ReadLine();
            dai = int.Parse(sdai);
            Console.WriteLine("Nhap chieu rong: ");
            string srong = Console.ReadLine();
            rong = int.Parse(srong);

            dientich = dai * rong;
            chuvi = (dai = +rong) * 2;
            canhnho = Math.Min(dai, rong);

            Console.WriteLine("Dien tich: " + dientich);
            Console.WriteLine("Chu vi: " + chuvi);
            Console.WriteLine("Canh nho: " + canhnho);
            Console.Read();
        }
    }
}
