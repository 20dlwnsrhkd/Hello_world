namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM9
{
static void Main9(String []args)
    {
        int cnt = 0;
        int avg = 0;
        Console.WriteLine("정수 배열을 생성합니다. 배열 크기 입력 :");
        cnt = int.Parse(Console.ReadLine());
        int[] numbers = new int[cnt]; // 입력한 크기의 배열 생성
        
        for(int i=0; i < cnt; i++){ 
            Console.WriteLine("{0}번째 데이터를 입력 :", i+110);
            numbers[i] = Convert.ToInt32(Console.ReadLine()); // 배열 값 초기화
        }
        for(int i=0; i < cnt; i++){ 
            avg += numbers[i];
            Console.WriteLine("배열의 값 : {0}", numbers[i]);
        }
        Console.WriteLine("숫자의 합 평균 : {0}", avg/cnt);
    }
}
