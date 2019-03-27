namespace ConsoleApp
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A) {
            int[] counters = new int[N];
            int maxCounter = 0;
            int lastMaxCounter = 0;
            bool DetectMaxCounter = false;
            bool[] useMaxCounter = new bool[N];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    DetectMaxCounter = false;
                    if (!useMaxCounter[A[i]-1])
                    {
                        counters[A[i]-1] = lastMaxCounter + 1;
                        useMaxCounter[A[i]-1] = true;
                    } else {
                        counters[A[i]-1]++;    
                    }

                    if (counters[A[i]-1] > maxCounter)
                    {
                        maxCounter = counters[A[i]-1];
                    }

                } else if(!DetectMaxCounter) {
                    DetectMaxCounter = true;
                    lastMaxCounter = maxCounter;
                    useMaxCounter = new bool[N];
                }
            }

            for (int i = 0; i < useMaxCounter.Length; i++)
            {
                if (!useMaxCounter[i])
                {
                    counters[i] = lastMaxCounter;
                }
            }

            return counters;
        }
    }
}