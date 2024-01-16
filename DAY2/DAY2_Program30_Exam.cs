namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM30{
    static void Main30()
        {
            string[] names = new string[4];
            int[] scores = new int[4];
            
            while(true){
                Console.WriteLine("메뉴를 선택하세요 : 1.학생 점수 입력, 2.학생 점수 출력, 3.프로그램 종료");
                string cho=Console.ReadLine();
                if(cho=="1"){
                    // 3명의 학생 정보 입력 받기
                    InputStudentInfo(ref names, ref scores, 3);
                }
                else if(cho=="2"){
                    // 학생 정보 출력
                    DisplayStudentInfo(names, scores, 3);
                    // 평균 점수 출력
                    double averageScore = CalculateAverageScore(scores, 3);
                    Console.WriteLine($"평균 점수: {averageScore:F2}");
                }
                else if(cho=="3"){
                    Console.WriteLine("프로그램을 종료합니다!");
                    break;
                }
                else{
                    Console.WriteLine("잘못된 입력입니다");
                }
            }



        }

        // 2명의 학생 정보 입력을 위한 오버로딩된 함수
        static void InputStudentInfo(ref string[] names, ref int[] scores, int numStudents)
        {
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"학생 {i + 1}의 이름을 입력하세요: ");
                names[i] = Console.ReadLine();

                Console.Write($"학생 {i + 1}의 점수를 입력하세요: ");
                int.TryParse(Console.ReadLine(), out scores[i]);
            }
        }


        // 학생 정보 출력을 위한 함수
        static void DisplayStudentInfo(string[] names, int[] scores, int numStudents)
        {
            Console.WriteLine("\n학생 정보:");

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"학생 {i + 1}: {names[i]}, 점수: {scores[i]}");
            }
        }

        // 평균 점수 계산을 위한 함수
        static double CalculateAverageScore(int[] scores, int numStudents)
        {
            int totalScore = 0;

            for (int i = 0; i < numStudents; i++)
            {
                totalScore += scores[i];
            }

            return (double)totalScore / numStudents;
        }
}