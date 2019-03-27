namespace ConsoleApp
{
    public class MaxDoubleSliceSum
    {

        //100% correct 42% performance
        public int solution(int[] A)
        {
            int result = 0;
            int maxEnding = -10000;
            int maxSlice = -10000;

            if (A.Length == 3)
            {
                return 0;
            }

            for (int m = 1; m < A.Length - 1; m++)
            {
                maxEnding = -10000;
                maxSlice = -10000;

                for (int i = 1; i < A.Length - 1; i++)
                {
                    if (m != i)
                    {
                        maxEnding = maxEnding + A[i] > A[i] ? maxEnding + A[i] : A[i];
                        maxSlice = maxEnding > maxSlice ? maxEnding : maxSlice;
                    }

                }

                result = result > maxSlice ? result : maxSlice;
            }



            return result;
        }


        public int solution1(int[] A)
        {
            int result = 0;
            int maxEnding = -10000;
            int maxSlice = -10000;
            int minElement = A[1];

            if (A.Length == 3)
            {
                return 0;
            }


            for (int i = 1; i < A.Length - 1; i++)
            {
                
                if (maxEnding + A[i] > A[i])
                {
                    minElement = minElement > A[i] ? A[i] : minElement;    
                    maxEnding = maxEnding + A[i];
                    maxSlice = maxEnding - minElement > maxSlice ? maxEnding - minElement : maxSlice;
                } else {
                    minElement = maxEnding = A[i];
                    maxSlice = maxEnding  > maxSlice ? maxEnding  : maxSlice;
                }
            }

            result = result > maxSlice ? result : maxSlice;
            

            return result;
        }

        public int solution2(int[] A){
            int tmp = 0;
            int result = 0;
            if (A.Length <= 3)
                return 0;
            

            int[] maxEndingLeft = new int[A.Length+1];
            int[] maxEndingRight = new int[A.Length+1];
            
            maxEndingLeft[0] = 0;
            for (int i = 1; i < A.Length; i++)
            {
                tmp = maxEndingLeft[i-1] + A[i];
                maxEndingLeft[i] = maxEndingLeft[i-1] + A[i] < 0 ? 0 : tmp;
            }            

            maxEndingRight[A.Length-1] = 0;
            for (int i = A.Length - 2; i > 0; i--)
            {
                tmp = maxEndingRight[i+1] + A[i];
                maxEndingRight[i] = tmp < 0 ? 0 : tmp;
            }

            for (int i = 1; i < A.Length-1; i++)
            {
                tmp = maxEndingLeft[i-1] + maxEndingRight[i+1];
                result = tmp > result ? tmp : result;

            }

            return result;
        }


    }
}