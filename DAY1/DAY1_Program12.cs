namespace Hello_world;
public class DAY1_PROGRAM12
{
static void Main12(String []args)
{
int x = 10, y = 3; // 한번에 나열하여 선언
double x2 = 10, y2 = 3.14;
int result1 = x + y;
Console.WriteLine("a와 b 연산 결과(순서대로 계산) : 복합{0}", y + x * y2 / x2); // 연산자 우선순위는?
Console.WriteLine("a와 b 연산 결과(우선순위 변경) : 복합{0}", (y + x) * (y2 / x2)); // () 괄호로 우선순위 지정
Console.WriteLine("a와 b 연산 결과(컴파운드 연산자) : 계산{0}", result1 +=2); // result = result + 2와 같음, 대입 연산자를 생략
Console.WriteLine("a와 b 연산 결과(증감연산자) : 계산{0}", result1++); // 1을 증가, 값 전달 이후 증가
Console.WriteLine("a와 b 연산 결과(증감연산자) : 계산{0}", ++result1); // 1을 증가, 증가 후 값 전달
Console.WriteLine("a와 b 연산 결과(증감연산자) : 계산{0}, 데이터 타입{1}", ++y2, y2.GetType()); // 실수 증감 후, 데이터 타입 변화 없음
}
}