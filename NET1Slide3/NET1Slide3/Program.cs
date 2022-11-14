using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1Slide3A
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] a ={3,4,5,9};
            //Console.WriteLine("For Thuong: ");
            //for(int i=0;i<a.Length;i++){
            //    Console.Write(a[i]+ " ");
            //}
            //Console.WriteLine("\nForeach:");
            //foreach(int x in a){
            //    Console.Write(x+" ");
            //}

            //------ tinh tong cac so chan cua mang
            //int tong=0;
            //int[] a={4,3,5,9,65,23,42};
            //foreach(int x in a){
            //    if(x%2 ==0){
            //        tong = tong +x;
            //    }
            //}
            //Console.WriteLine("Tong chan = "+tong);
            //--- viet lai dunng for thuong


            //--- ting va xuat trung binh cong ----------
            //int tong=0;
            //int[] a={4,3,5,9,65,23,42};
            //for(int i=0; i<a.Length; i++){              
            //    tong = tong +a [i];               
            //}
            //double tb = tong/a.Length;
            //Console.WriteLine("TB cong = " + tb);


            //---- mang nang cao --------
            //string[] names = {"Binh","An","Dung","Cuong"};
            //Console.WriteLine("Ban dau: ");
            //foreach(string ten in names){
            //    Console.WriteLine("\t- "+ten);
            //}

            //Console.WriteLine("Sort: ");
            //Array.Sort(names); // sap xep
            //foreach(string ten in names){
            //    Console.WriteLine("\t- "+ten);
            //}

            //Console.WriteLine("Reverse: ");
            //Array.Reverse(names);
            //foreach(string ten in names){
            //    Console.WriteLine("\t- "+ten);
            //}


            //---- thuat toan sap xep ----
            //int[] a = { 8, 2, 6, 3, 7, 1, 5 };
            //Console.WriteLine("Ban dau: ");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            //// sap xep 
            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < a.Length; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            int temp = a[i];
            //            a[i] = a[j];
            //            a[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("\nSau Sort: ");
            //foreach (int x in a)
            //{
            //    Console.Write(x + " ");
            //}

            //------------ ArrayList -----------

            //ArrayList a1 = new ArrayList();
            //a1.Add(1);
            //a1.Add("Example");
            //a1.Add(true);

            //Console.WriteLine(a1[0]);
            //Console.WriteLine(a1[1]);
            //Console.WriteLine(a1[2]);

            //Console.WriteLine("So phan tu: "+a1.Count);
            //Console.WriteLine("Tim 2: "+a1.Contains(2));
            //a1.RemoveAt(1);
            //Console.WriteLine(a1[1]);


            //---------------------------------------------
            //ArrayList a = new ArrayList();
            //int x = 0;
            //do
            //{
            //    Console.Write("Nhap so (0 to exit): ");
            //    x = int.Parse(Console.ReadLine());
            //    a.Add(x);
            //} while (x != 0);
            //Console.WriteLine("\nMang nhap: ");
            //foreach (int y in a)
            //{
            //    Console.Write(y + " ");
            //}
            //// dem co bao nhieu so chan
            //int count = 0;
            //foreach (int y in a)
            //{
            //    if (y % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("\nSo chan: " + count);
            //// xoa cac so chan           
            //for (int i = 0; i < a.Count; i++)
            //{
            //    if ((int)a[i] % 2 == 0)
            //    {
            //        a.RemoveAt(i);
            //    }
            //}
            //Console.WriteLine("Mang loai so chan: ");
            //foreach (int y in a)
            //{
            //    Console.Write(y + " ");
            //}
            //--------------------------------

            /*
            //----------- mang da chieu ------------------
            int[,] a = new int[,] { {2,4,3}, {4,6,5} };
            int d1 = a.GetLength(0);
            int d2 = a.GetLength(1);
            for(int i=0;i< d1;i++){
                for(int j=0;j<d2;j++){
                    Console.Write(a[i,j]+ " ");
                }
                Console.WriteLine();
            }
            //-------------------------
            */
            int[][] a = new int[4][];
            a[0] = new int[] { 1, 3, 2, 4 };
            a[1] = new int[] { 5, 7, 6 };
            a[2] = new int[] { 9, 8 };
            a[3] = new int[] { 5, 1, 2, 3, 4 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Dong({0}): ", i);
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            //---------------
            Console.Read();
        }
    }
}
