namespace ConsoleApp
{
    public class MaxProfit
    {
        //bruteforce solution
        public int solution(int[] A) {
            int maxProfit = 0;
            int tmp = 0;
            
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        tmp = A[j] - A[i];
                        maxProfit = maxProfit > tmp ? maxProfit : tmp;
                    }
                }
            }

            return maxProfit;
        }

        public int solution1(int[] A) {
            int maxSlice = 0;
            int maxEnding = 0;
            int diff = 0;
            

            for (int i = 1; i < A.Length; i++)
            {
                diff = A[i] - A[i-1];
                maxEnding = maxEnding + diff < 0 ? 0 : maxEnding + diff;
                maxSlice = maxSlice < maxEnding ?  maxEnding : maxSlice;

            }

            return maxSlice;
        }
    }
}