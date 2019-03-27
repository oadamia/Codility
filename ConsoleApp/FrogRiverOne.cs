using System;

namespace ConsoleApp
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A) {
            int minTime = 0;
            bool[] positions = new bool[X+1];
            int positionCount = 0;
            
            for (int second = 0; second < A.Length; second++)
            {
                if (!positions[A[second]]){
                    positionCount++;
                    positions[A[second]] = true;

                    if (minTime < second)
                    {
                        minTime = second;
                    }
                } 
                
            }

            if(positionCount == X)
            {
                return minTime;
            } 

            return -1;
        }
    }
}