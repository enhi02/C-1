using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            double c = 1.2, d = 5.6;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("--------------");
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("c = {0}, d = {1}", c, d);
            Console.ReadLine();
        }
    }
}
