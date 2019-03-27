namespace ConsoleApp
{
    public class MaxSliceSum
    {
        //brutoforce solution 100% correct
        public int solution(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = 0;
            bool hasNegativ = false;
            bool hasPositiv = false;

            if (A.Length == 1)
            {
                return A[0];
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    hasNegativ = true;
                }

                if (A[i] > 0)
                {
                    hasPositiv = true;
                }

                maxEnding = maxEnding + A[i] > 0 ? maxEnding + A[i] : 0;
                maxSlice = maxEnding > maxSlice ? maxEnding : maxSlice;

                maxSlice = maxSlice > A[i] ? maxSlice : A[i];
            }

            if (hasNegativ && !hasPositiv)
            {
                maxSlice = A[0];
                for (int i = 0; i < A.Length; i++)
                {
                    maxSlice = A[i] > maxSlice ? A[i] : maxSlice;
                }
            }

            return maxSlice;
        }

        //more elegant solution
        public int solution1(int[] A) {
            int maxEnding = -10000000;
            int maxSlice = -10000000;

            for (int i = 0; i < A.Length; i++)
            {
                maxEnding = maxEnding + A[i] > A[i] ? maxEnding + A[i] : A[i];
                maxSlice = maxEnding > maxSlice ? maxEnding : maxSlice;
            }

            return maxSlice;


        }

        public int solution2(int[] A) {
            int maxEnding = A[0];
            int maxSlice = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                maxEnding = maxEnding + A[i] > A[i] ? maxEnding + A[i] : A[i];
                maxSlice = maxEnding > maxSlice ? maxEnding : maxSlice;
            }

            return maxSlice;


        }


    }
}