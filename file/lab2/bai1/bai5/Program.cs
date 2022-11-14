using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j;
            Console.WriteLine("-In Ra Man Hinh Bang Cuu Chuong-");

            while (i <= 9)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
