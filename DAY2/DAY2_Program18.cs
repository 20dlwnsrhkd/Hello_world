namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM18
{
    static int Plus(int x,int y) // 더하기 함수
    { // 코드 블록 구분
        return x + y; // 합한 값을 리턴
    }
    static void Main18(string[] args) // 메인 멤버 함수, void(순수 함수, 반환형 : 리턴 값 없음) 
    { // 코드 블록 구분
        int x = 10; // main의 지역 변수
        int y = 5;
        int z = Plus(x, y); // 2개의 인자 값 전달 후 z에 저장
        Console.WriteLine("두 수를 합한 결과는 : {0}", z); // 합산 결과 출력
        Console.WriteLine("두 수를 합한 결과는 : {0}", Plus(x, y)); // 합수 호출과 함께 출력
    }
}
