using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> list = new List<product>();
            list.Add(new product() { Name = "tu lanh", Cost = 10, OnHand = "true" });
            list.Add(new product() { Name = "xe may", Cost = 100, OnHand = "true" });
            list.Add(new product() { Name = "ti vi", Cost = 15, OnHand = "true" });
            list.Add(new product() { Name = "ps", Cost = 150, OnHand = "true" });
            list.Add(new product() { Name = "dien thoat", Cost = 100, OnHand = "true" });
            foreach (var item in list)
            {
                Console.WriteLine("Product :" + item);
            }
            Console.ReadLine();
        }
    }
}
