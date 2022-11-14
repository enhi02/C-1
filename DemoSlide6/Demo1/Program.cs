using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //student sv = new student();
            //sv.name = "Teo";
            //sv.address = "Ho Chi Minh";
            //sv.course = "UDPM";
            //sv.show();
            //..................................
            //MyClass mc = new MyClass();
            //mc.PrintOut("Object");
            //IIfc1 ifc = (IIfc1)mc;
            //ifc.PrintOut("Interface");
            //..................................
            //MyData data = new MyData();
            //data.SetData(5);
            //Console.WriteLine("{0}", data.GetData());
            //..................................
            //Animal[] animalArray = new Animal[3];
            //animalArray[0] = new Cat();
            //animalArray[1] = new Bird();
            //animalArray[2] = new Dog();
            //foreach(Animal a in animalArray)
            //{
            //    ILiveBirth b = a as ILiveBirth;
            //    if(b != null)
            //    {
            //        Console.WriteLine("Baby is called: {0}", b.BabyCalled());
            //    }
            //}
            //...................................
            //// khai bao 3 doi tuong tau
            //Tau tau1 = new Tau();
            //Tau tau2 = new TauChien();
            //Tau tau3 = new TauDuLich();
            ////Goi phuong thuc lay thong tin
            //tau1.LayThongTin();
            //tau2.LayThongTin();
            //tau3.LayThongTin();
            //..................................
            Calculate c = new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);

            Console.ReadLine();
        }
    }
}
