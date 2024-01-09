namespace Hello_world;
public class DAY1_PROGRAM8
{
static void Main8(String []args)
{
Console.WriteLine("Enter your age:");
int age = Console.Read(); // age에 무엇이 들어갈지?, 처음에 실수 많이함
Console.WriteLine("Your age is: " + age); // 출력 결과는? 문자 1의 ASCII는?
Console.WriteLine("Enter your birth:");
var Birth = Convert.ToInt32(Console.ReadLine()); // 정수 타입 변환
Console.WriteLine("Your birth is: " + Birth);
Console.WriteLine("아무키나 한번 입력해줍니다"); // 중간 체크 - 잠시 정지
Console.ReadKey();
Console.WriteLine("Enter your name:");
var Name = Convert.ToString(Console.ReadLine()); // 문자열 타입 변환
Console.WriteLine("Your Name is: " + Name);
}
}