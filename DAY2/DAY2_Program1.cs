namespace C_SHARP_PROJECT; // 헬로 월드에서 수정됨
public class DAY2_PROGRAM1
{
static void Main1(String []args)
    {
        Console.WriteLine("while문을 테스트합니다. 수 한개를 입력하세요 : ");
        int input = Convert.ToInt32(Console.ReadLine());
        while(++input <= 10) // 조건식 : 증감연산자는 끝나는 조건
        {
            Console.WriteLine("반복 {0}", input); // input 부터 10일때 까지 반복
            // input++; 일반적인 코딩 스타일
        }
        Console.WriteLine("while문을 다시 테스트합니다. 수 한개를 입력하세요 : ");
        input = Convert.ToInt32(Console.ReadLine());
        while(input <= 10) // 조건식 : input에 증감연산자가 끝나는 조건
        {
            Console.WriteLine("반복 {0}", input); // input 부터 10일때 까지 반복
            --input; // 확실히 가독성 높음
            if(input<0){ // if문과 같이 조합
                break; // 특정 조건에서 정지 : 반드시 끝나는 조건 필요
            }
        }
    }
}
