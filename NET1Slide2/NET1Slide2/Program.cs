using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1Slide2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           int diem = 4;
           if(diem >= 5){
               Console.WriteLine("Dau ");        
           }
           */
            //----------- if else ---------------------
            /*
            int diem = 4;
            if(diem>=5){
                Console.WriteLine("Dau ");         
            }else{
                Console.WriteLine("Rot "); 
            }
            */
            //---------- vidu if else if -------------------------

            //int so;
            //Console.Write("Nhap so: ");
            //so = int.Parse(Console.ReadLine());
            //if (so == 2)
            //{
            //    Console.WriteLine("Thu " + so);
            //}
            //else if (so == 3)
            //{
            //    Console.WriteLine("Thu " + so);
            //}
            //else if (so == 4)
            //{
            //    Console.WriteLine("Thu " + so);
            //}
            //else if (so == 5)
            //{
            //    Console.WriteLine("Thu " + so);
            //}
            //else if (so == 6)
            //{
            //    Console.WriteLine("Thu " + so);
            //}
            //else if (so == 7)
            //{
            //    Console.WriteLine("Thu " + so);
            //}
            //else if (so == 8)
            //{
            //    Console.WriteLine("Chu nhat");
            //}
            //else
            //{
            //    Console.WriteLine("Over");
            //}

            //------- thue thu nhap ---------------------
            /*
            int luong, thuong, thunhap, thue;
            Console.Write("Luong: ");
            luong = int.Parse(Console.ReadLine());
            Console.Write("Thuong: ");
            thuong = Convert.ToInt32(Console.ReadLine());
            thunhap=luong + thuong;
            if(thunhap < 9000000){           
                thue=0;
                Console.WriteLine("Thu nhap: "+thunhap);
                Console.WriteLine("Thue thu nhap: "+thue);
            }else if(thunhap >= 9000000 && thunhap < 15000000){
                thue = thunhap * 10/100;
                Console.WriteLine("Thu nhap: "+thunhap);
                Console.WriteLine("Thue thu nhap: "+thue);
            }else if(thunhap >= 15000000 && thunhap < 30000000){
                thue=thunhap * 15/100;
                Console.WriteLine("Thu nhap: "+thunhap);
                Console.WriteLine("Thue thu nhap: "+thue);
            }else if(thunhap > 30000000){
                thue=thunhap * 20/100;
                Console.WriteLine("Thu nhap: "+thunhap);
                Console.WriteLine("Thue thu nhap: "+thue);
            }
            */
            //------------- switch case -----------
            /*
            double a,b;
            char option;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Chon (+ - * /) :");
            option = Convert.ToChar(Console.ReadLine());
            switch(option){
                case'+': 
                    Console.WriteLine(a+ " + "+b+" = " + (a+b)); 
                    break;
                case '-': 
                    Console.WriteLine(a+ " - "+b+" = " + (a-b)); 
                    break;
                case '*': 
                    Console.WriteLine(a+ " * "+b+" = " + (a*b)); 
                    break;
                case '/': 
                    Console.WriteLine(a+ " / "+b+" = " + (a/b));                    
                    break;
                default: 
                    Console.WriteLine("Vui long chon: +-/*");
                    break;
            }
            */
            //-------- vi du switch case---------------------
            /*
            int so;
            Console.Write("Nhap so: ");
            so = int.Parse(Console.ReadLine());
            switch(so){
                case 2: Console.WriteLine("Thu " + so); break;
                case 3: Console.WriteLine("Thu " + so); break;
                case 4: Console.WriteLine("Thu " + so); break;
                case 5: Console.WriteLine("Thu " + so); break;
                case 6: Console.WriteLine("Thu " + so); break;
                case 7: Console.WriteLine("Thu " + so); break;
                case 8: Console.WriteLine("Chu nhat "); break;
                default: Console.WriteLine("Over"); break;
            }
            */
            //----------------------
            Console.ReadKey();
        }
    }
}
