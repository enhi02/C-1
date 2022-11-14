using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1b
{
    public delegate void Toantu(double a, double b);
    class Toan
    {
        public void Tong (double a , double b)
        {
            Console.WriteLine("Tong Hai So:{0}", a + b);
        }

        public void Hieu (double a ,double b)
        {
            Console.WriteLine("Hieu Hai So:{0}", a + b);
        }

        public void Tich (double a ,double b)
        {
            Console.WriteLine("Hieu Hai So:{0}", a * b);
        }

        public void Thuong (double a , double b)
        {
            Console.WriteLine("Thuong Hai So:{0}", a / b);
        }
    }
}
