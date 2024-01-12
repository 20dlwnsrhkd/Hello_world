namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM27
{
    static int SumRecursive(int num, int total=1)
    {
        if (num == 1)
        {
            return total; // 종료조건 (base case)
        }
        else
        {
            Console.WriteLine("재귀 호출 전달 받은 값 : {0}",  num);
            return SumRecursive(num-1, num + total); // 수정된 꼬리재귀 함수
        }
    }
    static void Main27(string[] args)
    {
        Console.WriteLine("더하기 꼬리 재귀 함수를 시작합니다 : 정수를 입력해주세요");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("재귀 호출 더하기 결과 : {0}", SumRecursive(n));
    }
}
