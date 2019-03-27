using System;

namespace ConsoleApp
{
    public class PermMissingElem
    {
        public int solution(int[] A, int N){
            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return N+1;
        }
    }
}