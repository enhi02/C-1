using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Product : IDAction
    {
        public void Delete()
        {
            Console.WriteLine("Product in Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Product in Insert");
        }

        public void Select()
        {
            Console.WriteLine("Product in Select");
        }

        public void Update()
        {
            Console.WriteLine("Product in Update");
        }
    }
}
