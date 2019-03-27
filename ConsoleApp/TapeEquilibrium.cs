namespace ConsoleApp
{
    public class TapeEquilibrium
    {
        public int solution(int[] A) {
            int minDiff = 0;
            int tempDiff = 0;
            int part1 = A[0];
            int part2 = 0;

            for (int i = 1; i < A.Length; i++)
            {
                part2 += A[i];
            }

            minDiff = part2 - part1;

            if (minDiff < 0)
            {
                minDiff *= -1;
            }

            for (int p = 1; p < A.Length; p++)
            {
                tempDiff = part1 - part2;
                if (tempDiff < 0)
                {
                    tempDiff *= -1;
                }

                if (tempDiff < minDiff)
                {
                    minDiff = tempDiff;
                }

                part1 += A[p];
                part2 -= A[p];
            }

            return minDiff;
        }
    }
}