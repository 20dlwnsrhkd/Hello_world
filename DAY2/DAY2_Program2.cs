namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM2
{
    static void Main2(String []args)
    {
        Console.WriteLine("do-while문을 테스트합니다. 수 한개를 입력하세요 : ");
        int input = int.Parse(Console.ReadLine()); // 11을 입력해보자.
        do{
            Console.WriteLine("반복 {0}", input); // input 부터 10일때 까지 반복
            input++; // 증감연산자
        } while(input < 10);
        Console.WriteLine("do-while문을 다시 테스트합니다. 수 한개를 입력하세요 : ");
        input = int.Parse(Console.ReadLine());
        do{
            input--; // 증감연산자
            if(input%2==0){ // 2로 나눠지는 짝수이면
                continue; // continue 문으로 해당 루프 pass 가능
            }
            if(input < 0){ // 끝나는 조건
            break;
            }
            Console.WriteLine("반복 {0}", input); // input 부터 0일때 까지 반복
        } while(input < 10);
    }
}