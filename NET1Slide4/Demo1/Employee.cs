using System;

public class Employee {
    public String fullname;
    public double salary;
    public void input(){
        Console.Write("Fullname: ");
        this.fullname = Console.ReadLine();
        Console.Write("Salary: ");
        this.salary = Double.Parse(Console.ReadLine());
    }
    public void output(){
        Console.WriteLine("----------------------");
        Console.WriteLine("Faullname: "+fullname);
        Console.WriteLine("Salary: "+salary);
        Console.WriteLine("Tax: "+incomeTax());
    }
    public void setInfo(String fullname, double salary){
        this.fullname = fullname;
        this.salary = salary;        
    }
    public double incomeTax(){
        if(this.salary < 5000000){
            return 0;
        }
        double tax = (this.salary-5000000)*10/100;
        return tax;
    }
}