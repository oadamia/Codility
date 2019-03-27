namespace ConsoleApp
{
    public class Peaks
    {

        //brute force solution
        // 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2
        public int solution(int[] A)
        {
            var result = 0;
            var peaksCount = 0;
            var blockSize = 0;
            int[] peakPosition = new int[A.Length / 2 + 1];
            bool containcePeak = false;
            int blocksCount = 1;
            int lastPeakPosition = 1;

            if (A.Length < 3)
            {
                result = 0;
            }
            else
            {
                for (int i = 1; i < A.Length - 1; i++)
                {
                    if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    {
                        peaksCount++;
                        peakPosition[peaksCount] = i;
                    }
                }

                if (peaksCount < 2)
                {
                    result = peaksCount;
                }
                else
                {
                    blocksCount = peaksCount;

                    do
                    {
                        while (A.Length % blocksCount != 0)
                            blocksCount--;
                        lastPeakPosition = 1;
                        blockSize = A.Length / blocksCount;
                        containcePeak = true;
                        for (int i = 0; i < A.Length && containcePeak; i += blockSize)
                        {
                            containcePeak = false;
                            for (int j = lastPeakPosition; j <= peaksCount && !containcePeak; j++)
                            {
                                if (i <= peakPosition[j] && peakPosition[j] <= i + blockSize)
                                {
                                    containcePeak = true;
                                    lastPeakPosition = j;
                                }
                            }
                        }

                        if (containcePeak)
                        {
                            result = blocksCount;
                        } else {
                            blocksCount--;
                        }
                    } while (!containcePeak);
                }
            }


            return result;
        }

        // 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2
        public int solution1(int[] A)
        {
            var result = 0;
            var peaksCount = 0;
            var blockSize = 0;
            int blocksCount = 1;
            int[] peakPosition = new int[A.Length/3];
            bool containcePeak = false;
            int lastPeakPosition = 1;
            
            if (A.Length < 3)
            {
                result = 0;
            }
            else
            {
                for (int i = 1; i < A.Length - 1; i++)
                {
                    if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    {
                        peaksCount++;
                        peakPosition[peaksCount] = i;
                    }
                }

                if (peaksCount < 2)
                {
                    result = peaksCount;
                }
                else
                {
                    do
                    {
                        while (A.Length % blocksCount != 0 && blocksCount <= peaksCount)
                            blocksCount++;
                        lastPeakPosition = 1;
                        blockSize = A.Length / blocksCount;
                        containcePeak = true;
                        for (int i = 0; i < A.Length && containcePeak; i += blockSize)
                        {
                            containcePeak = false;
                            for (int j = lastPeakPosition; j <= peaksCount && !containcePeak; j++)
                            {
                                if (i <= peakPosition[j] && peakPosition[j] <= i + blockSize)
                                {
                                    containcePeak = true;
                                    lastPeakPosition = j;
                                }
                            }
                        }

                        if (containcePeak)
                        {
                            result = blocksCount;
                            blocksCount++;
                        }
                        
                    } while (containcePeak);
                }
            }


            return result;
        }

    }


}