using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Order : IDAction
    {
        void IDAction.Delete()
        {
            Console.WriteLine("Order in Delete");
        }

        void IDAction.Insert()
        {
            Console.WriteLine("Order in Insert");
        }

        void IDAction.Select()
        {
            Console.WriteLine("Order in Select");
        }

        void IDAction.Update()
        {
            Console.WriteLine("Order in Update");
        }
    }
}
