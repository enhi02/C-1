using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public interface IBook
    {
        string tenSach { get; set; }

        string tenTacGia { get; set; }

        string nhaXuatBan { get; set; }

        int namXuatBan { get; set; }

        string isbn { get; set; }

        string danhMuc { get; set; }

        void nhap();

        void xuat();

    }
}
