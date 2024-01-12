namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM7_1
{
    static void Main7_2(String []args){
        string passward="123123";
        int count=0;
        while(count<=5){
            Console.WriteLine("비밀번호를 입력해주세요: ");
            string pass= Console.ReadLine();
            if(pass.Length<=9||pass.Length>=6){
                if(pass=="123123"){
                    Console.WriteLine("로그인 성공!");
                    break;
                }
                else{
                    
                    Console.WriteLine("로그인실패, 5회 제안 현제 {0}회",++count);
                }

            }
            else{
                Console.WriteLine("로그인실패, 5회 제안 현제 {0}회",++count);
            }
        }

    }
}