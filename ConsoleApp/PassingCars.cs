namespace ConsoleApp
{
    public class PassingCars
    {
        public int solution(int[] A) {
            int pairCount = 0;

            int[] prefix = new int[A.Length+1];

            for (int i = 1; i <= A.Length; i++)
            {
                prefix[i] = prefix[i-1] + A[i-1];
            }


            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    pairCount += (prefix[A.Length] - prefix[i]);

                    if (pairCount > 1000000000)
                    {
                        pairCount = -1;
                        i=A.Length;
                    }
                }


            }

            return pairCount;
        }
    }
}