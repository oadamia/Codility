namespace ConsoleApp
{
    public class Distinct
    {
        public int solution(int[] A){
            int result = 1;

            if (A.Length == 0)
            {
                return 0;
            }

            System.Array.Sort(A);
            for (int i = 1; i < A.Length; i++)
            {

                if (A[i] != A[i-1])
                {
                    result++;
                }
            }
            return result;
        }
    }
}