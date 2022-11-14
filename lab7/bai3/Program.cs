using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            string a;
            do
            {
                student sv = new student();
                sv.input();
                students.Add(sv);
                Console.Write("nhap tiep (Y/N)");
                a = Console.ReadLine();
            } while (a == "y" || a == "Y");
            Console.WriteLine("--------NHAP THONG TIN SV---------");
            Console.WriteLine("ID\tName\t\tAge\tGenger\tCity");
            foreach(var SV in students)
            {
                SV.output();
            }

            Console.ReadLine();
        }
    }
}
