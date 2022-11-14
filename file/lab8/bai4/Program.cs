using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public delegate T SampleDelegate<T>(T a, T b);
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations ma = new MathOperations();
            SampleDelegate<int> dlgt = new SampleDelegate<int>(ma.Add);
            Console.WriteLine("Addition Result: " + dlgt(100, 90));
            dlgt = ma.Subtract;
            Console.WriteLine("Subtraction Result: " + dlgt(100, 90));

            Console.ReadLine();
        }
    }
}

