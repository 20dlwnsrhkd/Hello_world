namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM15
{
static void Main15(String []args)
    {
        string message1 = "오늘은 정말 '배고픈' 날입니다! HELLO"; // 기본 문자열
        int message_index = message1.IndexOf("HE"); // 문자 및 문자열 인덱스 확인
        Console.WriteLine($"문자열 위치(인덱스) : {message_index}");
        Console.WriteLine($"문자열 자르기1 : {message1.Substring(message_index, 5)}"); // 문자열 자르기
        Console.WriteLine($"특정 문자 변경 : {message1.Replace('L','l')}"); // 대문자 L --> l
        
        string[] message2 = message1.Split('\'',' '); // ' 따옴표와 공백 기준 자르기
        foreach(var word in message2){ // 분리된 문자열 반복
        Console.WriteLine($"문자열 자르기2 : {word}");
        }
        string message3 = "HELLO WORLD!";
        string reversed = new string(message3.Reverse().ToArray()); // for문이 아닌 reverse 함수, 새배열로 복사
        Console.WriteLine($"문자열 뒤집기 : {reversed}");
    }
} 