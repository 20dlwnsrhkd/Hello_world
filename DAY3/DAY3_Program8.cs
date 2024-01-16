namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM8
{
    ~DAY3_PROGRAM8(){ // 소멸자, 접근지정자 X
        Console.WriteLine("DAY3_PROGRAM7 : 소멸자 호출"); // 객체 생성 후 호출됨
    }
static void Main8(String []args)
    {
        Console.WriteLine("생성자/소멸자 호출 확인.");
        for(int i=0; i < 5; i++){
        initial3 test1 = new initial3(i); // 객체 생성하면 자동 생성자/소멸자 호출
        }
        GC.Collect(); // GC(가비지 컬렉터) 수행함
    }
}
class initial3{
    public initial3(int a){ // public 생성자
        int state = a;
        Console.WriteLine("initial : 인자값 {0}.", state); // 객체 생성 후 호출됨
    }
    ~initial3(){ // 소멸자, 접근지정자 X
        Console.WriteLine("initial : 소멸자 호출"); // 객체 생성 후 호출됨
    }
}