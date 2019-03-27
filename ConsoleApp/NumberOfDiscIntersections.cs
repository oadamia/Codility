using System;

namespace ConsoleApp
{
    public class NumberOfDiscIntersections
    {
        //Bruteforce Solution Correct = 100%
        public int solution(int[] A)
        {
            int result = 0;

            Circle[] discs = new Circle[A.Length];

            for (long i = 0; i < A.Length; i++)
            {
                discs[i] = new Circle() { point = i, radius = A[i], left = i - A[i], right = i + A[i] };
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (discs[i].left <= discs[j].right && discs[i].right >= discs[j].left)
                    {
                        result++;
                    }
                }
            }


            return result;
        }

        //first 100% solution
        public int solution1(int[] A)
        {
            long result = 0;
            int point = 0;
            int min = 0;
            int max = 0;


            Circle[] discs = new Circle[A.Length];

            for (long i = 0; i < A.Length; i++)
            {
                discs[i] = new Circle() { point = i, radius = A[i], left = i - A[i], right = i + A[i] };
            }

            Array.Sort(discs);

            for (int i = 0; i < discs.Length; i++)
            {
                min = 0;
                max = discs.Length;
                point = (max + min) / 2;

                while (point < discs.Length -1 && !(discs[point].left <= discs[i].right && discs[point+1].left > discs[i].right))
                {
                    if (discs[point].left <= discs[i].right)
                    {
                        min = point;
                    }
                    else
                    {
                        max = point;
                    }
                    point = (min + max) / 2;
                }

                if (point > 0)
                {
                    result = result + point - i;    
                    
                    if(result > 10000000){
                        result = -1;
                        i = discs.Length;
                    }

                }

                
            }

            return (int)result;
        }

        public struct Circle : IComparable
        {
            public long point;
            public long radius;
            public long left;
            public long right;

            public int CompareTo(object obj)
            {
                Circle c = (Circle)obj;

                return left.CompareTo(c.left);
            }
        }
    
        //second 100% solution (best solution)
        public int solution2(int[] A) {
            int result = 0;
            int[] dps = new int[A.Length];
            int[] dpe = new int[A.Length];

            for (int i = 0,t = A.Length -1; i < A.Length; i++)
            {   
                int s = i > A[i] ? i - A[i] : 0;
                int e = t - i > A[i] ? i + A[i] : t;
                dps[s]++;
                dpe[e]++;
            }

            for (int i = 0,t  = 0; i < A.Length; i++)
            {
                if (dps[i] > 0)
                {
                    result += t * dps[i];
                    result += dps[i] * (dps[i]-1)/2;
                    if (result > 10000000)
                        return -1;
                    t += dps[i];
                }
                t -= dpe[i];
            }
            

            return result;
        }
    
    }
}