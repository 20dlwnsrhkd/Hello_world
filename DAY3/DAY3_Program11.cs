namespace C_SHARP_PROJECT;
public class DAY3_PROGRAM11
{
    private int count = 0; // 멤버 변수 count
    DAY3_PROGRAM11(int count){ // 매개 변수 이름도 count, 음 이름이 같다? This로 구분하자.
        this.count = count; // 멤버 변수인 count에 매개변수 count를 할당 
        Console.WriteLine("생성자 호출 후 값 :{0}", count);
    }
    static void Main11(String []args)
    {
        Console.WriteLine("this 키워드 - 클래스의 멤버변수, 함수의 매개변수를 구분 : ");
        DAY3_PROGRAM11 main = new DAY3_PROGRAM11(777);
        main.set_count(666);
        Console.WriteLine("카운트 변경 후 값 :{0}", main.count);
    }
    public void set_count(int count){ // 인자는 count
        this.count = count; // 암묵적 잘 동작할까? this 키워드를 모두 제거하고 실행해보자.
    }
}