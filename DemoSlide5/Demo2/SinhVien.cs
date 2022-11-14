using System;
abstract public class SinhVien{
    public String hoTen;
    abstract public double getDienTB();
    public virtual void nhap(){
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
    }
    public virtual void xuat(){
        Console.WriteLine("Ho ten: "+hoTen);
    }
}
class SinhVienIT:SinhVien{
    public double diemJava;
    public double diemcss;
    public override double getDienTB(){
        return (2*diemJava + diemcss)/3;
    }
    public override void nhap(){
        base.nhap();
        Console.Write("Diem Java: ");
        diemJava = double.Parse(Console.ReadLine());  
        Console.Write("Diem css: ");
        diemcss = double.Parse(Console.ReadLine());        
    }
    public override void xuat(){
        base.xuat();
        Console.WriteLine("Diem TB " + getDienTB());
    }
}

class SinhVienBiz:SinhVien{
    public double keToan;
    public double marketting;
    public double banHang;
    public override double getDienTB(){
        return (keToan+marketting+banHang)/3;
    }
    public override void nhap(){
        base.nhap();
        Console.Write("Diem ke toan: ");
        keToan = double.Parse(Console.ReadLine());  
        Console.Write("Diem marketting: ");
        marketting = double.Parse(Console.ReadLine());      
        Console.Write("Diem ban hang: ");
        banHang = double.Parse(Console.ReadLine());   
    }
    public override void xuat(){
        base.xuat();
        Console.WriteLine("Diem TB " + getDienTB());
    }
}