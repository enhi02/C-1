using System;
class DongVat{
    public void Chay(){
        Console.WriteLine("Dong vat chay.");
    }
    // phuong thuc tinh
    public static void Ngu(){
        Console.WriteLine("Dong vat ngu.");
    }
}

class ConCun:DongVat{
    // phuong thuc cung ten voi lop cha
    public new void Chay(){
        // goi ham tu lop cha
        base.Chay();
        Console.WriteLine("Con cun chay.");
    }
}
