
using System;
public class SinhVien {
    public String hoTen;
    public double diemTB;
    public String xeploai(){
        String hocluc="";
        if(diemTB >=9){
            hocluc="Xuat Sac";
        }else if(diemTB >= 7.5 && diemTB <9){
            hocluc="Gioi";
        }else if(diemTB >=6.5 && diemTB <7.5){
            hocluc="Kha";
        }else if(diemTB >=5 && diemTB <6.5){
            hocluc="Trung binh";
        }else{
            hocluc="Yeu";
        }
        return hocluc;
    }
    public void xuat(){
        Console.WriteLine("-----------------");
        Console.WriteLine("Hoten: "+this.hoTen);
        Console.WriteLine("DiemTB: "+this.diemTB);
        Console.WriteLine("Xep loai: "+ xeploai());
    }
    public void nhap(){
        Console.Write("Ho ten: ");
        this.hoTen = Console.ReadLine();
        Console.Write("Diem TB: ");
        this.diemTB = Double.Parse(Console.ReadLine());
    }

    public SinhVien(String hoTen, double diemTB) {
        this.hoTen = hoTen;
        this.diemTB = diemTB;
    }

    public SinhVien() {
        this.hoTen="";
        this.diemTB=0;
    }
    
}