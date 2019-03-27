namespace ConsoleApp
{
    public class MissingInteger
    {
        public int solution(int[] A) {
            int result = 0;
            bool[] numberFlags;

            System.Array.Sort(A);

            if (A[A.Length-1] > 0)
            {
                numberFlags = new bool[A[A.Length-1]+2];
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > 0)
                    {
                        numberFlags[A[i]] = true;
                    }
                }

                int j = 1;
                while (numberFlags[j])
                {
                    j++;
                }

                result = j;
            } else {
                result = 1;
            }

            return result;
        }
    }
}