namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM26
{
    static int SumRecursive(int num)
    {
        if (num == 0)
        {
            return 0; // 종료조건 (base case)
        }
        else
        {
            Console.WriteLine("재귀 호출 전달 받은 값 : {0}",  num);
            return (int)(num + SumRecursive(num-1)); // 재귀 호출 (recursive function)
            }
    }
    static void Main26(string[] args)
    {
        Console.WriteLine("더하기 재귀 함수를 시작합니다 : 정수를 입력해주세요");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("재귀 호출 더하기 결과 : {0}", SumRecursive(n));
    }
}
