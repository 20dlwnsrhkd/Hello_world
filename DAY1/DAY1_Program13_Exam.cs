namespace Hello_world;
public class DAY1_PROGRAM13
{
    
    static void Main13(String []args)
    {
        Console.Write("첫번째 수를 입력해주세요 :");
        int a = int.Parse(Console.ReadLine());
        Console.Write("두번째 수를 입력해주세요 :");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("입력된 정수는 {0},{1}",a,b);
        Console.WriteLine("사칙연산 결과, 더하기 :{0}, 빼기 :{1}, 곱하기 :{2}, 나누기 :{3}, 나머지 :{4},",a+b,a-b,a*b,a/b,a%b);

    }
}