namespace Hello_world;
public class DAY1_PROGRAM6
{
public static void PrintValue(dynamic val) // 메서드 정의(dynamic 파라미터 전달)
{
Console.WriteLine(val.GetType()); //전달 값의 타입 출력
}
static void Main6(string[] args){
dynamic st_end, st_end2;
//Console.WriteLine("데이터 값 : {0}, 데이터 타입 : " + st_end.GetType(), st_end); // 컴파일 단계에서 인식 x
st_end = 100; st_end2 = null; // 나중에 데이터 할당 가능, but 널 값은 허용하지 않음
Console.WriteLine("데이터 값 : {0}, 데이터 타입 : " + st_end.GetType(), st_end); // 할당 이후 인식
st_end = 1.1; // 동적 타입이라 자동 완성 기능 지원 x
Console.WriteLine("데이터 값 : {0}, 데이터 타입 : " + st_end.GetType(), st_end); // 데이터 타입 변경
st_end = "hello";
Console.WriteLine("데이터 값 : {0}, 데이터 타입 : " + st_end.GetType(), st_end); // 최종 변경된 데이터 타입으로 출력
PrintValue("HelloWorld!"); // 문자열 전달
PrintValue(1000); // 정수 전달
PrintValue(10.50); // 실수 전달
}
}
