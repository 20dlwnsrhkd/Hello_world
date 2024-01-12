namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM28
{
    static int intPlus(int x, int y)
    {
    return x + y;
    }
    static float floatPlus(float x, float y)
    {
    return x + y;
    }
    static void Main28(string[] args)
    {
      int x = 10, y = 10;
      Console.WriteLine("더하기 함수를 시작합니다 : ");
      Console.WriteLine("더하기 결과 : 정수합 : {0} 실수합 : {1}", intPlus(x , y), floatPlus(x, y));
    }
}
