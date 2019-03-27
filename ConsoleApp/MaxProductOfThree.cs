namespace ConsoleApp
{
    public class MaxProductOfThree
    {
        public int solution1(int[] A)
        {
            int result = A[0]*A[1]*A[2];
            int max = 0;
            int p=0,q=0,r=0;

            for (int i = 0; i < A.Length-2; i++)
            {
                for (int j = i+1; j < A.Length-1; j++)
                {
                    for (int k = j+1; k < A.Length; k++)
                    {
                        max = A[i]*A[j]*A[k];
                        if (max > result)
                        {
                            p = i;
                            q = j;
                            r = k;
                            result = max;
                        }
                    }
                }
            }
            System.Console.WriteLine("p={0},q={1},r={2}",p,q,r);
            return result;
        }

        public int solution2(int[] A)
        {
            int result;
            System.Array.Sort(A);
         //   System.Console.WriteLine("[{0}]", string.Join(", ", A));
            if (A[0]>=0)
            {
                result = A[A.Length-3]*A[A.Length-2]*A[A.Length-1];
            } else if(A[1]<0) {
                if ((A[0]*A[1]*A[A.Length-1]) > (A[A.Length-3]*A[A.Length-2]*A[A.Length-1]))
                {
                    result = A[0]*A[1]*A[A.Length-1];
                } else {
                    result = (A[A.Length-3]*A[A.Length-2]*A[A.Length-1]);
                }

            } else {
                result = A[A.Length-3]*A[A.Length-2]*A[A.Length-1];
            }

            return result;
        }
        
    }
}