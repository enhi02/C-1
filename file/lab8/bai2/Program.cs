using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htbl = new Hashtable();
            htbl.Add(1, "Sunday");
            htbl.Add(2, "Monday");
            htbl.Add(3, "Tuesday");
            htbl.Add(4, "Wednesday");
            htbl.Add(5, "Thursday");
            htbl.Add(6, "Friday");
            htbl.Add(7, "Saturday");
            if (htbl.ContainsValue("Tuesday"))
            {
                Console.WriteLine("Tuesday in Hashtable ");
            }
            else
            {
                Console.WriteLine("Tuesday in Hashtable ");
            }
            foreach (DictionaryEntry item in htbl)
            {
                Console.WriteLine(" Key={0} , Value={1}", item.Key, item.Value);
            }
            Console.Read();
        }
    }
}
