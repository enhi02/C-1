using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable htbl = new Hashtable();
            htbl.Add("msg", "Welcome");
            htbl.Add("site", "Tutlane");
            htbl.Add(1, 20.5f);
            htbl.Add(2, 10);
            htbl.Add(3, 100);
            Console.WriteLine("Du lieu ban dau:");
            foreach(DictionaryEntry item in htbl)
            {
                Console.WriteLine("Key = {0}, value = {1}", item.Key, item.Value);
            }
            //-------------------------------------
            //htbl.Remove(1);
            //htbl.Remove("msg");
            //Console.WriteLine("Du lieu sau remove:");
            //foreach (DictionaryEntry item in htbl)
            //{
            //    Console.WriteLine("Key = {0}, value = {1}", item.Key, item.Value);
            //}
            //--------------------------------
            //Console.WriteLine("Contains key 4: {0}", htbl.Contains(4));
            //Console.WriteLine("Contains key 2: {0}", htbl.ContainsKey(2));
            //Console.WriteLine("Contains value 'Tutlane': {0}", htbl.ContainsValue("Tutlane"));
            //--------------------------------
            Console.WriteLine("--------Keys------------");
            foreach (Object key in htbl.Keys)
                Console.WriteLine(key);
            Console.WriteLine("--------Values:---------");
            foreach (Object value in htbl.Values)
                Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
