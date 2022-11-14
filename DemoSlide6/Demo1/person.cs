using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class person : Iperson
    {
        public string name;
        public string address;
        public void show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
}
