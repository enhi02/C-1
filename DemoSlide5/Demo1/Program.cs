using System;

namespace N1S5D1
{

    //public class NhanVien
    //{
    //    public long luong = 20000000;
    //}
    //public class KeToan : NhanVien
    //{
    //    public long tienThuong = 5000000;
    //}

    class Program
    {
        static void Main(string[] args)
        {

            //KeToan kt = new KeToan();
            //Console.WriteLine("Luong: " + kt.luong);
            //Console.WriteLine("Tien thuong: " + kt.tienThuong);


            //ChoCon cc = new ChoCon();
            //cc.TiengKeuChoCon();


            KeToan kt = new KeToan();
            Console.WriteLine("Luong ke toan: " + kt.luong);
            Console.WriteLine("Hoa hong ke toan: " + kt.hoaHong);

            LapTrinhVien ltv = new LapTrinhVien();
            Console.WriteLine("Luong lap trinh vien: " + ltv.luong);
            Console.WriteLine("Hoa hong lap trinh vien: " + ltv.hoaHong);

            QuanTriVien qtv = new QuanTriVien();
            Console.WriteLine("Luong quan tri vien: " + qtv.luong);
            Console.WriteLine("Hoa hong quan tri vien: " + qtv.hoaHong);

            Console.ReadLine();

        }
    }
}
