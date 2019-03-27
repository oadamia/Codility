namespace ConsoleApp
{
    public class CountFactors
    {
        public int solution(int N) {
            int result = 0;

            long i = 1;
            long n = (long)N;
            while (i * i < n)
            {
                if (n % i == 0)
                    result += 2;
                i++;
            }
            if (i * i == n)
                    result++;

            return result;
        }
    }
}