namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM23
{
static void Main23(string[] args) // 메인 멤버 함수
    {
        int x = 10; // 함수 내 지역변수들은 모두 스택으로~
        int y = 5;
        swap(ref x, ref y); // 현재 스택의 x, y의 참조를 전달
        Console.WriteLine("두 수를 교환한 결과는 : {0}과 {1}", x, y); // 교환되는가?
    }
    static void swap(ref int x, ref int y) // 교환 함수, x, y를 교환
    {
        int temp = x; // 임시 변수 사용, 나도 스택으로~
        x = y;
        y = temp;
        Console.WriteLine("두 수를 교환한 결과는(swap함수내) : {0}과 {1}", x, y); // 교환되는가?
    }
}