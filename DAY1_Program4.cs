namespace Hello_world;
public class DAY1_PROGRAM4
{
static void Main4(string[] args){
int x, y, z; // 소문자 변수
String X, Y, Z; // 대문자 변수
x = y = z = 50; // 한번에 모두 초기화
X = Y = Z = "HELLO_WORLD1 "; // 한번에 모두 초기화, 공백 포함
Console.WriteLine(x + y + z); // 숫자 합산
Console.WriteLine(X + Y + Z); // 문자 연결
Console.WriteLine(X + "아저씨{0}", Z); // 문자열과 변수 혼합 : Interpolation
Console.WriteLine(X + "아저씨{0}{1}", Z, y); // 2개 혼합
Console.WriteLine(X + "아저씨{1}{0}{1}", Z, y); // 순서 바꿈, 중첩 가능
Console.WriteLine("오늘 홍길동은" + "{0}를" + $"{x}번 외칩니다.", X); // 문자열과 변수 혼합(추가) : Placeholder
}
}