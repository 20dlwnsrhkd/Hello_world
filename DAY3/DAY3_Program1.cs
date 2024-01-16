namespace C_SHARP_PROJECT; 
public class DAY3_PROGRAM1 // 기본 클래스(개발자 기준)
{
    static string admin_Name = "관리자"; // 전역변수, 이름 중첩 : 정상 동작?
    static void Main1(String []args)
    {
        Console.WriteLine("개선된 객체지향의 세계로 오신것을 환영합니다(C++보다)");
        Console.WriteLine("학생 이름을 입력해주세요 :");
        string stName = Console.ReadLine(); // 지역변수
        student std1 = new student(); // 객체 인스턴스 생성
        student std2 = new student(); // 객체 인스턴스 생성(독립)
        std1.newMember(stName); // 클래스 내 메소드(함수) 호출
    }
}
class student{ // 학생 클래스
    public void newMember(string name){ 
        Console.WriteLine("{0} 학생. 방갑습니다!", name);
    }
}
