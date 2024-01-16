namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM6
{ 
    DAY3_PROGRAM6(){
        Console.WriteLine("DAY3_PROGRAM5 : 객체 생성시 1회 수행."); // 자동 호출 x
    }
static void Main6(String []args)
    {
        Console.WriteLine("생성자 호출 확인.");
        initial test = new initial(); // 객체 생성하면 자동 생성자 호출
    }
}
class initial{
    private readonly int number; // readonly 키워드(인스턴스 생성 후 변경 x), 초기화 필요 x
    private const int number2 = 5; // const 상수, 초기화 필요, 컴파일 시간
    public initial(){ // public 생성자
        number = 33; // readonly 생성자에서만 변경됨, 런타임(실행 후) 시간
        Console.WriteLine("initial : 객체 생성시 1회 수행."); // 객체 생성 후 호출됨
    }
}
