using System;

namespace ConsoleApp
{
    public class OddOccurancesInArray
    {
        public int solution(int[] A) {
            if (A.Length == 1)
            {
                return A[0];
            }
            Array.Sort(A);

            for (int i = 0; i < A.Length; i = i+2)
            {
                if (i+1 == A.Length)
                {
                    return A[i];
                }

                if (A[i]!= A[i+1])
                {
                    return A[i];
                }
            }

            return 0;
        }
    }
}