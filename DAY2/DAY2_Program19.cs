namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM19
{
    static void Main19(string[] args) // 메인 멤버 함수, 배열로 args(arugument) 입력
    {
    int argsCount = args.Length; // 입력 args 길이 체크
    
    if (argsCount < 2) // 2개가 입력 안되는 경우
    {
        Console.WriteLine("사용법 : MyApp.exe {inputFilename} {outputFilename}");
        Console.WriteLine(" 예) MyApp.exe data.inp data.out");
        return;
    }
    string inputFile = args[0]; // 첫번째 파일 이름
    string outputFile = args[1]; // 두번째 파일 이름
    Console.WriteLine("입력 파일: {0}, 출력 파일: {0}", inputFile, outputFile);
    }
}