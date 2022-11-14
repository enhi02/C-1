using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1Slide2B
{
    class Program
    {
        static void Main(string[] args)
        {

            //    int i = 1;
            //    while (i <= 10)
            //    {
            //        Console.WriteLine(i + ", Hello World !");
            //        i++;
            //    }


            //------ Cuu chuong 7 ---------------           
            //Console.WriteLine("In cuu chuong 7");
            //int i = 1, n = 7;
            //while (i <= 10)
            //{
            //    Console.WriteLine(n + " x " + i + " = " + (n * i));
            //    i++;
            //}

            /*
            //--------------- Cuu chuong tuy y ----
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i=1;
            while(i<= 10){
                Console.WriteLine(n+" x "+i+" = "+(n*i));
                i++;
            }
            //-----------------------------
            */
            /*
            //------- cac so chia het cho 3 tu min den max
            int min=27, max=250;        
            int i=0,dem=0,tong = 0;
            i=min;
            while(i <= max){
                if(i%3 ==0){
                    tong += i;
                    dem++;
                }         
                i++;
            }
            Console.WriteLine("TB cac so tu het cho 3 tu "+min+" den "+max+" = "+tong/dem);
            */
            /*
            //---------------- do while -------------
            int so = 0;   
            do{
                Console.Write("Nhap so duong: ");
                so = Convert.ToInt32(Console.ReadLine());
            }while(so<0);
            Console.Write("So: "+so);
            */
            /*
            //---- nhap so tu 0 --> 10
            double diem = 0;
            do{
                Console.Write("Nhap diem(0-10): ");
                diem = Convert.ToDouble(Console.ReadLine());
            }
            while(diem < 0 || diem > 10);
            Console.Write("Diem da nhap: "+ diem);
            */
            /*
            //------ for ------------------
            Console.Write("In tu 1 --> 10\n");
            for(int i=1;i<=10;i++){
                Console.Write(i+" ");
            }
            Console.Write("\nIn tu 10 --> 1\n");
            for(int i=10;i>=1;i--){
                Console.Write(i+" ");
            }
            */

            //------------- in ban cuu chuong -----
            //Console.Write("Nhap n: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(n + " x " + i + " = " + (n * i));
            //    Console.WriteLine("");
            //}
            // --NC: in bang cuu chuong tu 1-- > 9


            //----- for each ----
            int[] a = new int[10];
            Random r = new Random();
            // khoi tao gia tri cho cac phan tu cua mang
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(1, 20); // co the cho nguoi dung tu nhap thay random
            }
            // dung foreach hien thi cac phan tu cua mang
            //foreach (int val in a)           
            //{
            //    Console.Write(val + " ");
            //}
            for (int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + " ");
            }
            // NC: tinh tong cac phan tu chan, diem co bao nhieu so chan

            //--------- break continue ------------
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //        break;
            //    }
            //    Console.Write(i + " ");
            Console.ReadKey();
            }
        }
    }

