using System;
class Nguoi{
    // khai bao cac thuoc tinh
    public string maso;
    public string hoten;
    public string gioitinh;
    // phuong thuc khoi tao co 4 tham so
    public Nguoi(string maso, string hoten, string gioitinh){
        this.maso = maso;
        this.hoten = hoten;
        this.gioitinh = gioitinh;
    }
}

class NhanVien:Nguoi{
    private string bangcap;
    public NhanVien(string maso, string hoten, string gioitinh, string bangcap):base(maso,hoten,gioitinh){
        this.bangcap = bangcap;

    }
    public void xuat(){
        Console.WriteLine("MS: " + maso);
        Console.WriteLine("Ho ten: " + hoten);
        Console.WriteLine("Gioi tinh: " + gioitinh);
        Console.WriteLine("Bang cap: " + bangcap);
    }
}