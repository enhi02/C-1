using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class BookList
    {
        private List<Book> list = new List<Book>();

        public void sort()
        {
            list.Sort();
        }

        public void sapxep()
        {
            list.Sort(new BookComparer());
        }

        public void nhap()
        {
            string n;
            do
            {
                Book ds = new Book();
                ds.nhap();
                list.Add(ds);
                Console.WriteLine("ban muon nhap tiep khong(y or n)?: ");
                n = Console.ReadLine();
            } while (n != "n");
        }    

        public void xuat()
        {
            foreach(var item in list)
            {
                item.xuat();
            }    
        }
    }
}
