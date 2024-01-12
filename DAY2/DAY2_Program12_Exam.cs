namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM12
{
   static void Main12()
        {

            int[] donutsPerBag = { 4, 6, 11, 55, 34, 9, 12, 2, 1, 32 };
            

            int minDonuts = int.MaxValue;
            int maxDonuts = int.MinValue;

            foreach (int donuts in donutsPerBag)
            {
                minDonuts = Math.Min(minDonuts, donuts);
                maxDonuts = Math.Max(maxDonuts, donuts);
            }

            int totalDonuts = 0;
            foreach (int donuts in donutsPerBag)
            {
                totalDonuts += donuts;
            }
            totalDonuts-=(minDonuts+maxDonuts);

            Console.WriteLine($"최소 도너츠 개수: {minDonuts}");
            Console.WriteLine($"최대 도너츠 개수: {maxDonuts}");
            Console.WriteLine($"남은 빵의 전체 개수: {totalDonuts}");
        }
}