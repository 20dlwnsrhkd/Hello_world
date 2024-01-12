namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM6
{
static void Main6(String []args)
    {
        int[] numbers = {1, 2, 3, 5, 10, 15, 20}; // 정수 - 1차원 배열 선언
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; // 문자열 - 1차원 배열 선언
        Console.WriteLine("for-each를 테스트합니다.");
        // 내부 인덱스 끝까지 알아서 순환한다.
        foreach(int i in numbers){ // 데이터타입, 변수명 in 배열, 컬렉션 등
            Console.WriteLine("배열의 값 출력 {0}", i); 
        }
        foreach(string i in cars.Reverse()){ // 반대 방향 역 출력
            Console.WriteLine("배열의 값 출력 {0}", i); 
        }
    }
}
