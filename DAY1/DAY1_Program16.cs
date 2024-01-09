namespace Hello_world;
public class DAY1_PROGRAM16
{
static void Main16(String []args)
{
Console.WriteLine("당신의 c# 학점은 :?");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("당신의 c# 학점 등급은 :?");
char grade = Convert.ToChar(Console.ReadLine().ToUpper());
switch(grade)
{
case 'A':
if(a >= 90)
{
Console.WriteLine("{0}점입니다. 축하합니다.", a);
Console.WriteLine("등급은 {0} 입니다. 축하합니다.", grade);
}
else
{
Console.WriteLine("학점과 등급이 일치하지 않습니다. 종료");
}
break;
default:
Console.WriteLine("커트 라인 90점 이상 합격입니다. 다음 기회에...");
break;
}
}
}