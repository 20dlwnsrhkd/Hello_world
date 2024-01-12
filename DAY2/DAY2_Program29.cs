namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM29
{
    static int Plus(int x, int y)
    {
        Console.WriteLine("정수 연산");
        return x + y;
    }
    static float Plus(float x, float y)
    {
        Console.WriteLine("실수1 연산");
        return x + y;
    }
    static double Plus(double x, double y)
    {
        Console.WriteLine("실수2 연산");
        return x + y;
    }
    static void Main29(string[] args)
    {
        int x = 10;
        int y = 20;
        double d = 10.111;
        Console.WriteLine("더하기 함수를 시작합니다 : ");
        Console.WriteLine("더하기 결과 : 정수합 : {0} 실수합 : {1}", Plus(x , y), Plus(x, d));
    }
}