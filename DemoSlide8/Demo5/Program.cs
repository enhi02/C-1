using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
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
            Console.WriteLine("-----Generic Delegate Example -----");
            MathOperations m = new MathOperations();
            // Instance delegate with add method
            SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Add);
            Console.WriteLine("Addition Result: " + dlgt(10, 90));
            // Instance delegate with subtract method
            dlgt = m.Subtract;
            Console.WriteLine("Subtraction Result: " + dlgt(10, 90));
            Console.ReadLine();
        }
    }
}
