namespace Hello_world;
public class DAY1_PROGRAM3
{
static void Main3(string[] args){
const int myNum = 15; // 정수형 상수 선언
//myNum = 20; // 에러, 수정 하려면 재 컴파일 필요
const string ProductName = "Visual C#"; // 문자열 상수 선언
const string Version = "10.0";
const double X = 1.0, Y = 2.0, Z = 3.0; // 다수의 상수 선언
Console.WriteLine(myNum);
Console.WriteLine(ProductName);
Console.WriteLine(Version);
Console.WriteLine(X + Y + Z); // 정수의 합
Console.WriteLine(X + 1000); // 정수에 1000 더하기
Console.WriteLine("S/W : " + ProductName + " " + Version); // 문자열 +로 추가 조합
}
}