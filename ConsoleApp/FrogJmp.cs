namespace ConsoleApp
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D) {
            int diff = Y - X;
            int jumps = diff / D;

            if (X + D * jumps >= Y)
            {
                return jumps;
            } else {
                return jumps + 1;
            }
        }

    }
}