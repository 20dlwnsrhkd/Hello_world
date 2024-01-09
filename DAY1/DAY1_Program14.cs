namespace Hello_world;
public class DAY1_PROGRAM14{
static void Main14(String []args)
{
int a, b;
Console.Write("if문 예제 : 첫번째 수를 입력해주세요 :");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("if문 예제 : 두번째 수를 입력해주세요 :");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("입력된 두수는 {0}, {1}", a, b);
if(a > b) // 참,거짓 조건식 : 큰 수
{
Console.WriteLine("첫번째 입력한 수가 큰 수 입니다.");
}
else if(a == b) // 참,거짓 조건식 : 같은 수
{
Console.WriteLine("같은 숫자 입니다");
}
else // 참,거짓 조건식 : 이외 처리
{
Console.WriteLine("두번째 입력한 수가 큰 수 입니다.");
}
}
}