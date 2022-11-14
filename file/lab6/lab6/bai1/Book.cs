using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class Book : IBook, IComparable<Book>
    {
        public string tenSach { get; set; }

        public string tenTacGia { get; set; }

        public string nhaXuatBan { get; set; }

        public int namXuatBan { get; set; }

        public string isbn { get; set; }

        public string danhMuc { get; set; }

        public int CompareTo(Book other)
        {
            return this.tenSach.CompareTo(other.tenSach);
        }

        public void nhap()
        {
            Console.WriteLine("Xin moi nhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.WriteLine("Xin moi nhap ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.WriteLine("Xin moi nhap nha xuat ban: ");
            nhaXuatBan = Console.ReadLine();
            Console.WriteLine("Xin moi nhap nam xuat ban: ");
            namXuatBan = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Xin moi nhap danh muc: ");
            danhMuc = Console.ReadLine();

        }

        public void xuat()
        {
            Console.WriteLine($"{tenSach}\t\t{tenTacGia}\t\t{namXuatBan}\t\t{nhaXuatBan}\t\t{isbn}\t\t{danhMuc}");
        }
    }
}
