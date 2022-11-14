using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class MyClass : IIfc1
    {
        public void PrintOut(string s)
        {
            Console.WriteLine("Calling through:{0}", s);
        }
    }
}
