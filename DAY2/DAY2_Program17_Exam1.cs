namespace C_SHARP_PROJECT;

public class DAY2_PROGRAM17{
    static void Main17(String []args){
        Console.Write("문자열을 두 개 입력하여 주세요: ");
        string[] moon=Console.ReadLine().Split(' ');
        foreach( string i in moon){
            Console.WriteLine("{0}은 문자열의 길이 및 숫자 포함 검사 결과 {1}",i,(i.Length == 4 || i.Length == 6)&&(int.TryParse(i, out _)));
        }

    }
}


