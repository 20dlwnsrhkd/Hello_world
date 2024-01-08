namespace Hello_world1{ // 네임스페이스 괄호 적용
public class DAY1_Program1 // 접근 지정자 공개로 설정해야 함
{
public DAY1_Program1(){ // 접근 지정자 공개
String man ="아저씨2";
System.Console.WriteLine("Hello, World2!"); // system 직접 추가
Console.WriteLine(man);
}
}
}
namespace Hello_world2{ // 다른 네임 스페이스
class DAY1_Program1
{
static void Main1(string[] args){ // 실행 기준
String man ="아저씨1";
Console.WriteLine("Hello, World1!");
Console.WriteLine(man);
Hello_world1.DAY1_Program1 test = new Hello_world1.DAY1_Program1(); // 네임스페이스로 호출
}
}
}