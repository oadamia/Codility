namespace ConsoleApp
{
    public class Triangle
    {
        public int solution(int[] A) {
            int result = 0;
            long p,q,r;


            if (A.Length == 0)
            {
                return 0;
            }

            System.Array.Sort(A);

            for (int i = 0; i < A.Length - 2; i++)
            {
                p = (long)A[i] + (long)A[i+1];
                q = (long)A[i+1] + (long)A[i+2];
                r = (long)A[i+2] + (long)A[i];
                if (p > A[i+2] 
                    && q > A[i]
                    && r > A[i+1])
                {
                    result = 1;
                }
            }

            return result;
        }
    }
}