namespace Hello_world;
public class DAY1_PROGRAM15
{
static void Main15(String []args)
{
Console.WriteLine("당신의 c# 학점 등급은?");
char grade = Convert.ToChar(Console.ReadLine().ToUpper()); // 문자 1개를 입력받음, 대문자 변환
switch(grade)
{
case 'A':
Console.WriteLine("1등 입니다. 축하합니다.");
break;
case 'B':
Console.WriteLine("매우 잘했습니다. 축하합니다.");
break;
case 'C':
Console.WriteLine("휴 겨우 해냈어요!. 축하합니다.");
break;
case 'D':
case 'x': // 중간에 여러개 조건 중첩 추가 가능
case 'd':
Console.WriteLine("다시봐요~. ");
break;
default:
Console.WriteLine("학점을 입력해주세요. ㅜㅜ ");
break;
}
}
}