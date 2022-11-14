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
            int canh, thetich;
            Console.WriteLine("Xin moi nhap canh: ");
            string scanh = Console.ReadLine();
            canh = int.Parse(scanh);

            Console.WriteLine("The tich cua hinh lap phuong: "+ (canh*canh*canh));
            Console.Read();
        }
    }
}
