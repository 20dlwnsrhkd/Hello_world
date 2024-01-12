namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM21
{
    static void Main21(string[] args)
    {
        int a = 3; // 정수 초기화
        int b = 6;
        int c = 7;
        paramsPractice(new int[] { a, b, c}); // 기존 호출 방식
        int[] array = paramsPractice(a, b, c); // params 적용 후(가독성!)
        Console.WriteLine("PARAMS 키워드 테스트 : 단순 배열 출력");
        foreach(var cnt in array){ // 끝까지 반복
            Console.WriteLine(cnt);
        }
    }
    public static int[] paramsPractice(params int[] array) // params 키워드 적용
    {
        return array; // 단순 배열 리턴
    }
}
