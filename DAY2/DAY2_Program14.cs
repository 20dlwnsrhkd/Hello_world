namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM14
{
    static void Main14(String []args)
    {
        string message1 = "문자열 초기화"; // STRING 클래스는 불변 클래스(변경 x)
        string message2 = message1 + " " + "afadddDDD"; // + 연산자로 연결
        string code_message = @"
        public string ReadFile(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                return File.ReadAllText(filename);
            }
                return string.Empty;
        }
        ";
        Console.WriteLine($"문자열\t 값 출력 1 : {message1}"); // 단순(보간) 출력, 이스케이프(탭)
        Console.WriteLine($@"문자열\t 값 출력\n 2 : {message1}\t"); // @ 심벌로 이스케이프 무시
        Console.WriteLine($"문자열 값 출력 3 : {code_message}"); // @ 심벌로 + 없이 코드 입력
        Console.WriteLine($"문자열 길이 : {code_message.Length} 대소문자 {message2.ToUpper()}"); // 메서드 활용
        }
}
