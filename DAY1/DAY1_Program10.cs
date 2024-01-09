namespace Hello_world;
public class DAY1_PROGRAM10
{
    static void Main10(String []args)
    {
        int i = 100000;
        double d = 1.00001;
        double e = 1.00001;
        char chr = 'C';
        float flt = 0.0001f; // 실수 f 표기
        Console.WriteLine("변환 전 {0} 데이터 타입 {1}.", d, d.GetType()); // 데이터 타입은 Double
        d = i; // int --> double로 (캐스팅 결과 : 암시적(자동) 변환)
        Console.WriteLine("변환 후 {0} 데이터 타입 {1}.", d, d.GetType()); // 데이터 타입 변화 없음
        d = (double) i; // int --> double로 (캐스팅 결과 : 명시적 변환)
        Console.WriteLine("변환 후 {0} 데이터 타입 {1}.", d, d.GetType()); // 데이터 타입은 변화 없음
        //i = e; // 에러 이유가?
        i = (int)e; // double --> int로 명시적 변환
        Console.WriteLine("반대로 변환{0}", i); // 소수점 어디갔니? 데이터 손실이 발생한다. (큰걸 --> 작은걸로)
        flt = chr; // 문제 없음
        //chr = flt; // 역시 반대 방향은 에러다.
    }
}