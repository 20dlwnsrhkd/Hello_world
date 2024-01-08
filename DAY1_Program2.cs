namespace Hello_world; // 괄호 묶음 { } 해제
public class DAY1_Program2
{
static void Main2(string[] args){
int myNum; // 변수 이름만 선언
myNum = 5; // 선언 후 초기화, 최대 2147483647
double myDoubleNum = 5.99D; // 선언과 동시에 초기화
char myLetter = 'D'; // 문자는 ‘ ‘ 따옴표로 묶음
bool myBool = true; // false
string myText = "Hello"; // 문자열 “ “ 로 묶음
Console.Write(myNum); // 줄바꿈 없는 출력
Console.Write("\n"); // 개행 : 이스케이프 문자
Console.WriteLine(myDoubleNum); // 줄바꿈과 함께 출력
Console.WriteLine(myLetter);
Console.WriteLine(myBool);
Console.WriteLine(myText);
}
}