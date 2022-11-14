using System;
public class ChuNhat {
    public double dai,rong;

    public ChuNhat(double canh) {
        this.dai=canh;
        this.rong=canh;
    }

    public ChuNhat() {
        this.dai=0;
        this.rong=0;
    }

    public ChuNhat(double dai, double rong) {
        this.dai = dai;
        this.rong = rong;
    }
    public void print(){
        Console.WriteLine("-----------");
        Console.WriteLine("Dai: "+dai);
        Console.WriteLine("Rong: "+rong);
    }
}