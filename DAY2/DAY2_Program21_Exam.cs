using System.ComponentModel;

namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM21_Exam
{
    static void Main21_2(string[] args)
    {
        Console.WriteLine("사칙연산에 필요한 수의 갯수는? :");
        int num= int.Parse(Console.ReadLine());
        int[] k =new int[num];
        for(int i=0; i<num;i++){
            Console.WriteLine("{0}번째 데이터를 입력:",i);
            k[i]= int.Parse(Console.ReadLine());
            
        }
        while(true){
            Console.WriteLine("계산기 메뉴 : 1. 더하기 2. 곱하기 3.종료 :");
            string value= Console.ReadLine();
            if(value=="1"){
                Console.WriteLine("더하기 결과 : {0}",Add(k));
            }
            else if(value=="2"){
                Console.WriteLine("곱하기 결과 : {0}",Mul(k));
            }
            else if(value=="3"){
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }
            else{
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    
    }
    public static int Add( int[] array) // params 키워드 적용
    {
        int result =0;
        foreach(int pp in array){
            result+=pp;
        }
        return result;
    }
    public static int Mul( int[] array) // params 키워드 적용
    {
        int result =1;
        foreach(int pp in array){
            result*=pp;
        }
        return result;
    }

}
