using System;

namespace ConsoleApp
{
    public struct result
    {
        public int index;
        public int slice;
        public decimal average;
    }

    public class MinAvgTwoSlice
    {
        public result solution(int[] A)
        {
            result r = new result();
            int[] prefixSum = new int[A.Length + 1];
            int[] P = new int[A.Length - 1];
            int[] Q = new int[A.Length - 1];
            decimal average = 0;
            decimal minAverage = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                P[i] = i;
                Q[i] = i + 1;
            }

            for (int i = 1; i <= A.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i - 1];
            }

            minAverage = (decimal)(prefixSum[Q[0] + 1] - prefixSum[P[0]]) / (Q[0] - P[0] + 1);
            r.index = P[0];
            r.slice = Q[0] - P[0] + 1;

            for (int i = 0; i < P.Length; i++)
            {
                for (int j = i; j < Q.Length; j++)
                {
                    average = (decimal)(prefixSum[Q[j] + 1] - prefixSum[P[i]]) / (Q[j] - P[i] + 1);
                    if (average < minAverage)
                    {
                        minAverage = average;
                        r.index = P[i];
                        r.slice = Q[j] - P[i] + 1;
                        r.average = average;
                    }
                }
            }

            return r;
        }

        //Correct Solution and most Efficient
        public result solution1(int[] A)
        {
            result r = new result();
            int[] prefixSum = new int[A.Length + 1];
            decimal average = 0;
            decimal minAverage = 0;
            bool increaseSlice = true;

            for (int i = 1; i <= A.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i - 1];
            }

            minAverage = (decimal)(prefixSum[2] - prefixSum[0]) / (2);
            r.index = 0;
            r.slice = 2;
            r.average = minAverage;

            for (int slice = 2; slice < A.Length && increaseSlice; slice++)
            {
                if (slice > 2)
                {
                    increaseSlice = false;
                }
                
                for (int i = 0; i < A.Length - slice + 1; i++)
                {
                    average = (decimal)(prefixSum[i + slice] - prefixSum[i]) / slice;
                    if (average < minAverage  || (average == minAverage && i < r.index))
                    {
                        minAverage = average;
                        r.index = i;
                        r.slice = slice;
                        increaseSlice = true;
                        r.average = average;
                    }
                }

            }
            return r;
        }

        public result solution2(int[] A)
        {
            result r = new result();
            int[] prefixSum = new int[A.Length + 1];
            decimal average = 0;
            decimal minAverage = 0;

            for (int i = 1; i <= A.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i - 1];
            }

            minAverage = (decimal)(prefixSum[2] - prefixSum[0]) / (2);
            r.index = 0;
            r.slice = 2;
            r.average = minAverage;

            for (int slice = 2; slice < A.Length; slice++)
            {
                for (int i = 0; i < A.Length - slice + 1; i++)
                {
                    average = (decimal)(prefixSum[i + slice] - prefixSum[i]) / slice;
                    if (average < minAverage || (average == minAverage && i < r.index))
                    {
                        minAverage = average;
                        r.index = i;
                        r.slice = slice;
                        r.average = average;
                    }
                }

            }

            
            return r;
        }
    }
}