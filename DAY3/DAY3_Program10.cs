namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM10
{
static void Main10(String []args)
    {
        Console.WriteLine("private 데이터 접근 어떻게 하나?.");
        string stName = "아저씨";
        admin_get3 std = new admin_get3(); // 객체 인스턴스 생성
        Console.WriteLine("기밀정보, 주민정보 몰래 출력 {0}, {1}", std.info1_set_get, std.info2_set_get);    
        // std.info2_set_get = 516555; // 주민번호 수정 에러(읽기 전용)
        std.info1_set_get = stName; // () 괄호 없음, 기밀정보 수정
        std.info2_set_get = "581823"; // 주민번호 수정
        Console.WriteLine("기밀정보, 주민정보 수정 후 출력 {0}, {1}", std.info1_set_get, std.info2_set_get);
        Console.WriteLine(std.print());; // 속성을 출력
    }
}
class admin_get3{ 
    private string info1 = "기밀정보"; // private 으로 설정, 외부 차단!
    private string info2 = "901112"; // private 으로 설정, 외부 차단!
    private int property_test {get; set;} = 999999; // 자동 속성 초기화
    public string info1_set_get{ // set/get을 속성 하나로 정의
        set{ info1 = value; } // value는 예약어
        get{ return info1; } // 리턴
    }
    public string info2_set_get{ // set/get을 속성 하나로 정의
        set{ info2 = value; } // value는 예약어
        get{ return info2; } // 리턴
    }
    public int print(){ // 단순 출력을 위한 속성 리턴
        return property_test;
    }
}