using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + " + " + b + " = {0}", a + b);
        }
        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine(a + " + " + b + " + "+ c +" = {0}", a + b+c);
        }
    }
}
