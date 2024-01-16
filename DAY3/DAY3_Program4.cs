namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM4
{
static void Main4(String []args)
    {
        Console.WriteLine("private 데이터 접근 어떻게 하나?.");
        string stName = "아저씨";
        admin_get2 std = new admin_get2(); // 객체 인스턴스 생성
        Console.WriteLine("기밀정보, 주민정보 몰래 출력 {0}, {1}", std.get_info1(), std.get_info2());    
        std.set(516555); // 주민번호 수정
        std.set(stName); // 기밀정보 수정
        Console.WriteLine("기밀정보, 주민정보 수정 후 출력 {0}, {1}", std.get_info1(), std.get_info2());  
    }
}
class admin_get2{ 
    private string info1 = "기밀정보"; // private 으로 설정, 외부 차단!
    private int info2 = 901112; // private 으로 설정, 외부 차단!
    
    public string get_info1(){ // public 으로 지정
        return info1;
    }
     public int get_info2(){ // public 으로 지정
        return info2;
    }
    public void set(string set_info1){ // public 으로 지정, 함수 오버로딩
        info1 = set_info1;
    }
    public void set(int set_info2){ // public 으로 지정
        info2 = set_info2;
    }
}
