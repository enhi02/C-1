using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class student:person
    {
        public string course;
        public new void show()
        {
            base.show();
            Console.WriteLine("Course: " + course);
        }
    }
}
