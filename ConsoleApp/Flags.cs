namespace ConsoleApp
{
    public class Flags
    {
        //bruteforce solution
        public int solution(int[] A)
        {
            if (A.Length < 3)
                return 0;

            int[] peaks = new int[A.Length / 3 + 1];
            int peaksCount = 0;
            int minDistance = A.Length;
            int flagsCount = 0;
            int tmpFlagsCount = 0;

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    peaks[peaksCount] = i;
                    if (peaksCount > 0)
                    {
                        var tmp = peaks[peaksCount] - peaks[peaksCount - 1];
                        minDistance = tmp < minDistance ? tmp : minDistance;
                    }
                    peaksCount++;

                }
            }

            flagsCount = peaksCount;
            int peakIncrement = 1;
            while (minDistance < flagsCount)
            {
                minDistance++;
                peakIncrement = 1;
                for (int i = 0; i < peaksCount; i += peakIncrement)
                {
                    peakIncrement = 1;
                    while (peaksCount > i + peakIncrement && peaks[i + peakIncrement] - peaks[i] < minDistance)
                    {
                        peakIncrement++;
                    }


                    tmpFlagsCount++;
                }

                flagsCount = tmpFlagsCount;

            }

            return flagsCount;
        }

        public int solution1(int[] A)
        {
            if (A.Length < 3)
                return 0;

            int[] peaks = new int[A.Length / 3 +1];
            int peaksCount = 0;
            
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    
                    if (peaksCount == 0)
                    {
                        peaks[peaksCount] = i;
                        peaksCount++;
                    } else if (i - peaks[peaksCount-1] >= peaksCount)
                    {
                        peaks[peaksCount] = i;
                        peaksCount++;
                    }
                }
            }
            
            
            
            return peaksCount;
        }
    }
}