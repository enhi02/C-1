using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        public static void HoanDoi<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 1; int b = 2;
            double x = 200, y = 100;
            Console.WriteLine("a={0} , b={1}", a, b);
            HoanDoi<int>(ref a, ref b);
            Console.WriteLine("a={0} , b={1}", a, b);
            Console.WriteLine("--------------------");
            Console.WriteLine("x = {0}, y = {1}", x, y);
            HoanDoi<double>(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.Read();
        }
    }
}
