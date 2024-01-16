namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM2
{
    static string admin_Name = "관리자"; // static 클래스 변수다.
    static void Main2(String []args)
    {
        Console.WriteLine("클래스 변수와 인스천스 변수 구별이 되나요?");
        Console.WriteLine("선생 이름을 입력해주세요 :");
        string stName = Console.ReadLine(); // 지역변수
        admin_new std = new admin_new(); // 객체 인스턴스 생성
        admin_new.oldMember(stName); // 클래스 직접 접근 가능(객체생성 없이)
        admin_new.temp = "임시에 접근"; // 클래스 직접 접근 가능(객체생성 없이)
        std.newMember(stName); // 학생은 직접 접근 안될까?
    }
}
class admin_new{ // 같은 네임스페이스에 동일 클래스 이름 존재 하면 에러
    public static string temp = "임시"; // static 클래스 변수다, 근데 인스턴스(객체) 마다 생성
    public void newMember(string name){ 
        Console.WriteLine("{0} 학생. 방갑습니다!", name);
    }
    public static void oldMember(string name){
        Console.WriteLine("{0} 선생. 방갑습니다!", name);
    }
}
