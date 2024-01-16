namespace C_SHARP_PROJECT;
public class DAY3_Program9_Exam2
{
    static string[] name;
    static int[] score;
    static string pass_input;
    DAY3_Program9_Exam2()
    {
        name = new string[3]{"GUEST", "GUEST", "GUEST"};
        score = new int[3]{0, 0, 0};
    }
    static void Main(String []args)
    {
        DAY3_Program9_Exam2 start = new DAY3_Program9_Exam2();
        student_inout2 st = new student_inout2();
        student_inout2.student_login st2 = new student_inout2.student_login();
        while(true){
        Console.WriteLine("로그인 필요, 패스워드를 입력하세요 : ");
        pass_input = Console.ReadLine();
        if(st2.get_password() == pass_input){
            st.input_score(name, score);
            break;
        }
        else{
            Console.WriteLine("패스워드가 틀립니다.");
        }
        }
    }
}

public class student_inout2{
    public class student_login{
        private string password = "123123";
        public string get_password(){
            return password;
        }
    }
    public void input_score(string[] name, int[] score)
    {
        while(true)
        {
            Console.WriteLine("메뉴를 선택하세요 : 1. 학생 점수 입력 2. 학생 점수 출력 3. 프로그램 종료 ");
            int a = int.Parse(Console.ReadLine());
            if(a == 1)
            {
                Console.WriteLine("학생 이름과 점수를 입력합니다 :");
                for(int i=0; i<3; i++)
                {
                Console.WriteLine("{0}번재 학생의 이름은? : ", i);
                name[i] = Console.ReadLine();
                Console.WriteLine("{0}번쨰 학생의 점수는? : ", i);
                score[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("학생 정보 입력 완료!");
            }
            else if(a == 2)
            {
                print_info(name, score);
            }
            else if(a==3)
            {
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }
    public void print_info (string[] name, int[] score)
    {
        for(int i=0; i<3; i++)
                {
                Console.WriteLine("{0}번쨰 학생 이름 : {1}, 점수 : {2}", i, name[i],score[i]);
                }

                Console.WriteLine("학생 3명의 평균 점수는 {0}점", score.Average());
    }
}