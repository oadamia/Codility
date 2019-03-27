namespace ConsoleApp
{
    public class CountDiv
    {
        public int solution(int A,int B,int K) {
            if (A < K && K < B && A != 0)
                A = K;
            
            int result = (B - A)/K;

            if (A % K == 0 || B % K == 0)
                result++;
            
            return result;
        }
    }
}