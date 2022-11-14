
    using System;
    public delegate void SampleDelegate2(int a, int b);
    class MathOperation2{
        public void Add(int a, int b){
            Console.WriteLine("Add result: {0}", a+b);
        }
        public void Subtract(int a, int b){
            Console.WriteLine("Subtract result: {0}", a-b);
        }
        public void Multiply(int a, int b){
            Console.WriteLine("Multiply result: {0}", a*b);
        }
    }