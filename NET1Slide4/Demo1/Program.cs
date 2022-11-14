using System;

namespace N1S3D1
{
    class Program
    {
        static void Main(string[] args)
        {

            //HinhTron ht = new HinhTron();
            //ht.banKinh = 10;
            //Console.Write("Chu vi: " + ht.getChuvi());


            //------------------------------
            //Employee emp1 = new Employee();
            //Employee emp2 = new Employee();

            //emp1.input();
            //emp2.input();

            //emp1.output();
            //emp2.output();
            //-----------------------------------           

            //ChuNhat cn1 = new ChuNhat(20, 15);
            //ChuNhat vu = new ChuNhat(30);
            //ChuNhat cn2 = new ChuNhat();
            //cn1.print();
            //vu.print();
            //cn2.print();


            SinhVien sv1 = new SinhVien("Teo", 8.5);
            SinhVien sv2 = new SinhVien("Gai", 7.0);
            sv1.xuat();
            sv2.xuat();

            /*
            SinhVien sv1 = new SinhVien();
            SinhVien sv2 = new SinhVien();
            sv1.nhap();
            sv2.nhap();
            sv1.xuat();
            sv2.xuat();
            */

            //Console.Write("Nhap so SV: ");
            //int n = int.Parse(Console.ReadLine());
            //SinhVien[] ds = new SinhVien[n];
            //for (int i = 0; i < ds.Length; i++)
            //{
            //    SinhVien sv = new SinhVien();
            //    sv.nhap();
            //    ds[i] = sv;
            //}

            //for (int i = 0; i < ds.Length; i++)
            //{
            //    ds[i].xuat();
            //}


            //int a = 10;
            //int b = 20;
            //Console.WriteLine("truoc khi Swap: a = {0}, b={1}", a, b);
            //////Hoai vi
            //Swap(ref a, ref b);
            //Console.WriteLine("truoc khi Swap: a = {0}, b={1}", a, b);

            //int x;
            //GetValue(out x);
            //Console.WriteLine("x = {0}",x);

            Console.Read();
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
        public static void GetValue(out int x)
        {
            x = 5;
        }
    }
}
