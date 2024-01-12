namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM11
{
static void Main11(String []args)
    {
        int[,] array = new int [2, 3]; // 1차원 배열(가로)을 세로로 배치
        Console.WriteLine("차원={0}, 길이={1}", array.Rank, array.Length); // 메서드 기능
        int[,] arr = new int[2, 3] {{1, 2, 3}, {4, 5, 6}}; // 길이 명시
        int[,] arr2 = new int[,] {{1, 2, 3}, {4, 5, 6}}; // 길이 생략
        int[,] arr3 = {{1, 2, 3}, {4, 5, 6}}; // 기본 표현
        for (int i = 0; i < arr3.GetLength(0); ++i) // 이중 for문으로 값 추가
        {
            for(int j=0; j < arr3.GetLength(1); ++j) // getLength 함수(행, 열) 길이
            {
               arr3[i, j] = arr3[i, j] + 1;
            }
        }
        foreach (int greeting in arr3)
            Console.WriteLine($"2차원 배열의 값 출력 : {greeting}");
    }
}
