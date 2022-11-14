using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class DbManager
    {
        static void Main(string[] args)
        {
            IDAction db1 = new Product();
            IDAction db2 = new Order();

            db1.Insert();
            db2.Insert();

            Console.ReadKey();
        }
    }
}
