using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class student
    {
        private string ID { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        
        public void input()
        {
            Console.Write("Nhap ID sv: ");
            ID = Console.ReadLine();
            Console.Write("Nhap ten sv: ");
            name = Console.ReadLine();
            Console.Write("nhap tuoi sv: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine($"{ID}\t{name}\t{age}");
        }


    }
}
