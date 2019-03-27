namespace ConsoleApp
{
    public class MinPerimeterRectangle
    {
        public int solution(int N) {
            
            int perimeter = (N + 1)*2;
            int i = 1;

            while (i * i <= N)
            {
                if (N % i == 0)
                {
                    var o = N / i;
                    var tmp =  (i + o) * 2;
                    perimeter = tmp < perimeter ? tmp : perimeter;
                }
                i++;
            }

            return perimeter;
        }

        //more efficient solution
        public int solution1(int N) {
            
            int sqrt = (int)System.Math.Sqrt(N);

            while (true)
            {
                if (N % sqrt == 0)
                {
                    break;
                }
                sqrt--;
            }

            return (sqrt + N / sqrt) * 2;
        }
    }
}