using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class BookComparer : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {                       
                int result = x.tenTacGia.CompareTo(y.tenTacGia);
                if (result == 0)
                    result = x.tenSach.CompareTo(y.tenSach);
                if (result == 0)
                    result = x.namXuatBan.CompareTo(y.namXuatBan);
                return result;            
       }
    }
}
