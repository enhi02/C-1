using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class product
    {
        public string Name { get; set; }

        public double Cost { get; set; }

        public string OnHand { get; set; }
        public override string ToString()
        {
            string st = string.Format("--{0}----{1}----{2}--", Name, Cost, OnHand);
            return st;
        }
    }
}
