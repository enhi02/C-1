using System;
public class baseClass{
    public virtual void show(){
        Console.WriteLine("Base class");
    }
}
class derived:baseClass{
    public override void show(){
        Console.WriteLine("Derived class");
    }
}