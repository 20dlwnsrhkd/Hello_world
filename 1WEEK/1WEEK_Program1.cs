namespace C_SHARP_PROJECT;
public class WEEK_PROGRAM1
{
    
     static void Main31()
        {
            string residentNumber;
 
            do
            {
                Console.Write("주민등록번호를 입력하세요 (12자리 또는 13자리): ");
                residentNumber = Console.ReadLine();
                residentNumber=residentNumber.Replace("-", "").Replace(" ", "");
            } while (!IsValidResidentNumber(residentNumber));

            string filteredNumber = FilterResidentNumber(residentNumber);
            Console.WriteLine($"주민번호는 {filteredNumber}입니다.");
            char genderCode=residentNumber[6];
            
            string gender = DetermineGender(genderCode);
            string birthYear = DetermineBirthYear(genderCode);

                Console.WriteLine($"성별: {gender}, 출생년대: {birthYear}");
            
        }

        static bool IsValidResidentNumber(string number)
        {

            if (string.IsNullOrEmpty(number) || (number.Length != 12 && number.Length != 13))//초기엔 12자리 주민번호를 사용하였다고 합니다..
            {
                Console.WriteLine("주민등록번호가 유효하지 않습니다. 다시 입력하세요.");
                return false;
            }

            if(number.Length==13){
                // 체크 계산
                int checkSum = CalculateCheckSum(number);

                // 마지막 자리값 일치 검사
                int lastDigit = int.Parse(number.Substring(12, 1));
                return (11 - (checkSum % 11)) % 10 == lastDigit;
            }
            else{
                return true;
            }
        }

        static string FilterResidentNumber(string number)
        {
            // 뒷자리 7자리 *로 변경
            int length = number.Length;
            if (length == 13)
            {
                return  number.Substring(0,6) + "*******";
            }
            else
            {
                return  number.Substring(0,6) + "******";
            }
        }

        static int CalculateCheckSum(string residentNumber)
        {
            int[] checkNumbers = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5 };
            int checkSum = 0;

            for (int i = 0; i < 12; i++)
            {
                int digit = int.Parse(residentNumber.Substring(i, 1));
                checkSum += digit * checkNumbers[i];
            }

            return checkSum;
        }
        static string DetermineGender(char genderCode)
        {
            switch (genderCode)
            {
                case '1':
                case '3':
                case '5':
                case '7':
                case '9':
                    return "남자";
                case '2':
                case '4':
                case '6':
                case '8':
                case '0':
                    return "여자";
                default:
                    return "알 수 없음";
            }
        }

        static string DetermineBirthYear(char genderCode)
        {
            switch (genderCode)
            {
                case '1':
                case '2':
                case '5':
                case '6':
                    return "1900년대 출생";
                case '3':
                case '4':
                case '7':
                case '8':
                    return "2000년대 출생";
                case '9':
                case '0':
                    return "1800년대 출생";
                default:
                    return "알 수 없음";
            }
        }
}