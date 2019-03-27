namespace ConsoleApp
{
    public class MaximumSliceProblem
    {
        public int slowMaxSlice(int[] A){
            int result = 0;
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j < A.Length; j++)
                {
                    sum = 0;
                    for (int k = i; k < j+1; k++)
                    {
                        sum += A[k];
                    }
                    result = sum > result ? sum : result;
                }
            }

            return result;
        }

        public int quadraticMaxSlice(int[] A) {
            int result = 0;
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum = 0;
                for (int j = i; j < A.Length; j++)
                {
                    sum += A[j];
                    result = sum > result ? sum : result;
                }
            }


            return result;
        }

        public int goldenMaxSlice(int[] A) {
            int maxEnding = 0;
            int maxSlice = 0;

            for (int i = 0; i < A.Length; i++)
            {
                maxEnding = maxEnding + A[i] > 0 ? maxEnding + A[i] : 0;
                maxSlice = maxEnding > maxSlice ? maxEnding : maxSlice;
            }

            return maxSlice;
        }
        
    }
}