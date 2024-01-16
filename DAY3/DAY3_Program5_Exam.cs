/*namespace C_SHARP_PROJECT
{
    public class Student
    {
        private string name;
        private int score;

        public void InputScore()
        {
            Console.Write("학생 이름을 입력하세요: ");
            name = Console.ReadLine();

            Console.Write("학생 점수를 입력하세요: ");
            int.TryParse(Console.ReadLine(), out score);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"학생 이름: {name}, 점수: {score}");
        }

        public string GetName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }
    }

    public class DAY3_Program5_Exam1
    {
        const int MaxStudents = 4;

        static void Main5()
        {
            Student[] students = new Student[MaxStudents];

            while (true)
            {
                Console.WriteLine("메뉴를 선택하세요 : 1.학생 점수 입력, 2.학생 점수 출력, 3.프로그램 종료");
                string cho = Console.ReadLine();

                switch (cho)
                {
                    case "1":
                        InputStudentInfo(students);
                        break;
                    case "2":
                        DisplayStudentInfo(students);
                        double averageScore = CalculateAverageScore(students);
                        Console.WriteLine($"평균 점수: {averageScore:F2}");
                        break;
                    case "3":
                        Console.WriteLine("프로그램을 종료합니다!");
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;
                }
            }
        }

        static void InputStudentInfo(Student[] students)
        {
            Console.Write("학생 수를 입력하세요: ");
            int numStudents;

            if (int.TryParse(Console.ReadLine(), out numStudents) && numStudents >= 2 && numStudents <= MaxStudents)
            {
                for (int i = 0; i < numStudents; i++)
                {
                    students[i] = new Student();
                    students[i].InputScore();
                }
            }
            else
            {
                Console.WriteLine("학생 수가 올바르지 않습니다.");
            }
        }

        static void DisplayStudentInfo(Student[] students)
        {
            Console.WriteLine("\n학생 정보:");

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    students[i].PrintInfo();
                }
            }
        }

        static double CalculateAverageScore(Student[] students)
        {
            int totalScore = 0;
            int validStudents = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    totalScore += students[i].GetScore();
                    validStudents++;
                }
            }

            return validStudents > 0 ? (double)totalScore / validStudents : 0;
        }
    }
}
*/