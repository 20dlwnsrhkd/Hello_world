namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM13
{
static void Main13(String []args)
    {
        string message1 = "문자열 초기화"; // 기본 문자열
        string message_null = String.Empty; // 빈 문자열 ""과 동일(안전한 null)
        string message_start = "문자열의 시작부터 ";
        string message_end = "끝까지!";
        
        Console.WriteLine($"문자열\t 값 출력 1 : {message1}"); // 단순(보간) 출력, 이스케이프(탭)
        Console.WriteLine($"문자열 값 \'출력 2\' : {message_start + message_end}"); // 문자열 결합, 이스케이프(작은 따옴표)
        
        int number = 15;
        string message3 = string.Format("숫자 --> 문자{0}", number); // 이전 방식 format 서식 지정, 가독성 떨어짐
        Console.WriteLine("문자열 변환 출력 3 : {0}", message3);
        string time = String.Format("It is now {0:d} at {0:t}", DateTime.Now); // 현재 시각 지정
        string price = String.Format("Price is {0:C}", 512123123);
        Console.WriteLine("문자열 변환 출력 4 : {0}", price); // 통화 형식
        Console.WriteLine("문자열 변환 출력 4 : {0}", time); // 날짜 형식, 시간 형식
        Console.WriteLine($"문자열\t 값 출력 5 : {Math.PI}"); // 단순(보간) 출력, PI 값(DOUBLE형 느려질수 있음)
        Console.WriteLine($"문자열\t 값 출력 5 : {Math.PI.ToString()}"); // 단순(보간) 출력, PI 값(미리 STRING 처리)
    }
}