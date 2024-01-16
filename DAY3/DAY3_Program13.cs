namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM13
{
    static void Main13(String []args)
    {
        University2.Department2 outin = new University2.Department2(); // 대학 내부 학과 인스턴스 생성
        // University.Department.Print_Department(); 외부 --> 내부 하위 메서드는 접근 불가
        outin.Print_Department();
    }
}
public class University2 // 외부 대학 클래스
{
    private int pass = 123123;
    public void Print_University(int a)
    {
        Console.WriteLine("성결대학교 외부 Method 호출 {0}", a);
    }
    public class Department2 // 내부 학과 클래스 : public 선언 필요
    {
        public void Print_Department()
        {
            University2 inout = new University2(); // 내부 클래스에서 외부 클래스 생성 가능
            inout.Print_University(123123); // 내부에서 외부출력, 인자전달 가능
            inout.pass = 455788; // 내부에서 외부 멤버 변수 접근 가능
            Console.WriteLine("성결대학교 내부 --> 외부 값 변경 {0}", inout.pass);
        } 
    }
}