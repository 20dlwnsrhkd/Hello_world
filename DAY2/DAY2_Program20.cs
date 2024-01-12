namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM20
{
    static void Main20(string[] args) // 메인 멤버 함수
    {
        int x = 10; // main의 지역 변수
        int y = 5;
        int z1 = Plus(x, y); // 기본적인 인수 전달 방법
        int z2 = Plus(); // 인수 기본 값 전달
        int z3 = Plus(5); // 인수 1개 x=5만 전달 – 선택적 매개변수
        //int z4 = Plus( ,5); 인수 뒷 부분 전달은 에러
        int z4 = Plus(y:10, x:-3); // 인수 이름을 아는 경우(순서 x) – 명명된 매개변수
        Console.WriteLine("두 수를 합한 결과는 : {0}", z1); // 합산 결과 출력
        Console.WriteLine("두 수를 합한 결과는 : {0}", z2); 
        Console.WriteLine("두 수를 합한 결과는 : {0}", z3);
        Console.WriteLine("두 수를 합한 결과는 : {0}", z4);
    }
    static int Plus(int x=3, int y=5) // 더하기 함수, 인수 기본 값 설정, 하단에 위치
    {
        return x + y; // 합한 값을 리턴
    }
}