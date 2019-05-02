using System;

namespace ConsoleApp
{
    public class SieveofEratosthenes
    {
        public bool[] solution(int n)
        {
            bool[] result = new bool[n];
            int j;
            int k;

            for (int i = 0; i < n; i++)
            {
                result[i] = true;
            }

            result[0] = result[1] = false;

            j = 2;
            while (j * j <= n)
            {
                if (result[j])
                {
                    k = j * j;
                    while(k < n){
                        result[k] = false;
                        k += j;
                    }       
                }
                j++;
            }

            return result;
        }

        public int[] factorization()
        {
            return new int[] {0};
            
        }


    }
}
