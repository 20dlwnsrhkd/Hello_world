namespace Hello_world;
public class DAY1_PROGRAM17{
    static void Main17(String []args)
    {
        Console.Write("현제 시간을 입력해주세요 :");
        int a = int.Parse(Console.ReadLine());
        Console.Write("현제 분을 입력해주세요 :");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("현제시간은 {0}시{1}분 입니다.",a,b);
        Console.Write("요리 시간을 입력해주세요 :");
        int c = int.Parse(Console.ReadLine());
        if(b+c>60){
            a+=(b+c)/60;
            b=(b+c)%60;

        }

        Console.WriteLine("요리가 완료될  예상시간은 {0}시{1}분 입니다.",a,b);

    }
}