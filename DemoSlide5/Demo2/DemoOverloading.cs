public class DemoOverloading{
    public int Sum(int A, int B){
        return A+B;
    }
    public float Sum(int A, float B){
        return A+B;
    }
    public int Sum(int A, int B, int C){
        return A+B+C;
    }
}