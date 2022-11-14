using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            student sv = new student();
            sv.name = "Teo";
            sv.address = "Ho Chi Minh";
            sv.course = "UDPM";
            sv.show();
            Console.ReadKey();
        }
    }
}
