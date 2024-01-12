namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM24
{
static void Main24(string[] args) // 메인 멤버 함수
    {
        int x; // 네. 저는 초기값 없어도 에러 X
        int y;
        out_test(out x, out y); // out 타입으로 인수 정의
        Console.WriteLine("두 수는 : {0}과 {1}", x, y); // 변수 출력
    }
    static void out_test(out int x, out int y) // out 함수로 x, y를 바깥으로
    {
        x = 30;
        y = 15;
        Console.WriteLine("두 수는(함수내) : {0}과 {1}", x, y); // 변수 출력
    }
}
