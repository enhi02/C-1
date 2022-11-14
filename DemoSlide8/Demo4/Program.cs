using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class GenericClass<T>
    {
        public T msg;
        public void generisMethod(T name, T location)
        {
            Console.WriteLine("{0}", msg);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Generics Example ------");

            GenericClass<string> gclass = new GenericClass<string>();
            gclass.msg = "Welcome to Fpoly";
            gclass.generisMethod("Le Van Teo", "Ho Chi Minh");

            Console.WriteLine("------------------");
            GenericClass<int> iclass = new GenericClass<int>();
            iclass.msg = 1;
            iclass.generisMethod(2, 3);
            Console.ReadKey();

        }
    }
}
