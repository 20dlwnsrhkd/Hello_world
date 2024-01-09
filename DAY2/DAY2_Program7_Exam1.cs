namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM7
{
    static void Main7(String []args){
        while(true){
            Console.WriteLine("정수 a를 입력하세요 : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a==0 || b==0){
                Console.WriteLine(" 프로그램을 종료합니다");
                break;
            }
            Console.WriteLine("두 수의 합은 :{0}+{1}={2} ",a,b,a+b);
        }

    }
}