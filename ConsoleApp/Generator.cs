using System;

namespace ConsoleApp
{
    public class Generator
    {
        //small random, lenght ~ 100
        // N is an integer within the range [2..100,000];
        // each element of array A is an integer within the range [−10,000..10,000]
        public static int[] MinAvgTwoSlice1(int N, int min, int max) {
            int[] result = new int[N];
            Random ran = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ran.Next(min,max);
            }

            return result;
        }

        public static int[] GenerateNumberArray(int n,int min,int max) {
            int[] result = new int[n];
            Random ran = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ran.Next(min,max);
            }

            return result;
        }
    }
}