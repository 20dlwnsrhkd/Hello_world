namespace Hello_world;
//var i = 20; // 전역 변수 선언 불가
public class DAY1_PROGRAM5
{
//var i = 20; // 메서드 내에서만
static void Main5(string[] args){
var i = 20;
var st = "행복합";
var d = 20.333;
var st_end ="니다";
//var st_end; // 선언과 동시에 초기화 : NULL 예외가 발생 X
//var st_end = 123; // 데이터 타입 변경 x
st_end = "니까?";
Console.WriteLine("{0} " + "{1}{2}" + st_end, i, st, d); // 혼합 출력(모두 동작 ok)
Console.WriteLine("데이터 타입 확인 :" + i.GetType()); // System에 미리 지정된 데이터 타입
Console.WriteLine("데이터 타입 확인 :" + st.GetType());
Console.WriteLine("데이터 타입 확인 :" + d.GetType());
}
}
