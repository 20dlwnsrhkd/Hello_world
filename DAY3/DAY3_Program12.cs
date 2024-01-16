namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM12
{
    static void Main12(String []args)
    {
        University uni = new University(); // 대학 인스턴스 생성
        uni.Print_University();
        University.Department dep = new University.Department(); // 대학 내부 학과 인스턴스 생성
        dep.Print_Department();
    }
}
public class University // 외부 대학 클래스
{
    public void Print_University()
    {
        Console.WriteLine("성결대학교 외부 Method 호출");
    }
    public class Department // 내부 학과 클래스 : public 선언 필요
    {
        public void Print_Department()
        {
            Console.WriteLine("성결대학교 내부 Method 호출");
        } 
    }
}
