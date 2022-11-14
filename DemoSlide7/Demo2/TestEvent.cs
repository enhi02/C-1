using System;
public delegate void PrintDetails();
class TestEvent{
    event PrintDetails Print;
    void Show(){
        Console.WriteLine("Hay hien thi toi ra man hinh");
    }
    static void Main(string[] agrs){
        TestEvent objTestEvent = new TestEvent();
        objTestEvent.Print += new PrintDetails(objTestEvent.Show);
        objTestEvent.Print();
        Console.ReadLine();
    }
}