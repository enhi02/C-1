using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    // khai bao Delegate
    public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add result: {0}", a + b);
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtract result: {0}", a - b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //-------Single Cast Delegates------------
            //Console.WriteLine("---------- Delegate Example -------");
            //MathOperations m = new MathOperations();
            //// instantiale delegate with add method
            //SampleDelegate dlgt = m.Add;
            //dlgt(10,90);
            //// instantiale delegate with subtract method
            //dlgt = m.Subtract;
            //dlgt(10,90);


            //------- Multi cast Delegates -----------

            //MathOperation2 m = new MathOperation2();
            //SampleDelegate2 dlgt = m.Add;
            //dlgt += m.Subtract;
            //dlgt += m.Multiply;
            //dlgt(10,90);

            //-------------------------
            MathOperation2 m = new MathOperation2();
            SampleMethod(m.Add, 10, 80);
            SampleMethod(m.Subtract, 10, 80);
            SampleMethod(m.Multiply, 10, 80);

            Console.ReadLine();
        }
        static void SampleMethod(SampleDelegate2 dlgt, int a, int b)
        {
            dlgt(a, b);
        }
    }
}
