using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so: ");
            string Sso = Console.ReadLine();
            int N = int.Parse(Sso);
            Boolean ok = true;
            for (int i = 2; i < N - 1; i++)
            {
                if (N%i==0)
                {
                    ok = false;
                    break;
                }    
            }
            if(ok==true)
            {
                Console.WriteLine(N + "la so nguyen to");
            }
            else
            {
                Console.WriteLine(N + "khong phai la so nguyen to");
            }
            Console.ReadKey();
        }
    }
}
