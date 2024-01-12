namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM16
{
static void Main16(String []args)
    {
        string message1, message3; // 문자열 할당 선언
        message1 = message3 = "오늘은 정말 배아파요!"; // 문자열 연속 초기화
        string message2 = "오늘은 정말 배가 불러요?"; // 다른 문자열
        string message4 = "HELLO_WORLD!"; 
        string message5 = "hello_world!";
        Console.WriteLine($"문자열 비교 1 : {string.Equals(message1, message3)}"); // 같은 문자열 true
        Console.WriteLine($"문자열 비교 2 : {(message1 == message3)}"); // 같은 문자열 true
        Console.WriteLine($"문자열 비교 3 : {string.Compare(message1, message3)}"); // 같은 문자열 0
        Console.WriteLine($"문자열 비교 4 : {string.Compare(message1, message2)}"); // 다른 문자열 1
        Console.WriteLine($"문자열 비교 5 : {(message4 == message5)}"); // 다른 문자열?
        Console.WriteLine($"문자열 비교 6 : {(message4.Equals(message5, StringComparison.OrdinalIgnoreCase))}"); // 대소문자 무시 비교
        string message_null1 = "";
        string message_null2 = " ";
        string message_null3 = "\n";
        Console.WriteLine($"문자열 널 확인 1 : {String.IsNullOrEmpty(message_null1)}"); // 공백이면 true
        Console.WriteLine($"문자열 널 확인 2 : {String.IsNullOrEmpty(message_null2)}"); // 공백 1개 이상이면?
        Console.WriteLine($"문자열 널 확인 3 : {String.IsNullOrWhiteSpace(message_null2)}"); // 공백도 널 처리
        Console.WriteLine($"문자열 널 확인 4 : {String.IsNullOrEmpty(message_null3)}"); // 개행은?
    }
}   
