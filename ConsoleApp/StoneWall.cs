namespace ConsoleApp
{
    public class StoneWall
    {
        //Brute force solution 100% correct
        public int solution(int[] H) {
            System.Collections.Stack st = new System.Collections.Stack();

            int b;
            int counter = 0;
            int wallHeight = 0;
            for (int i = 0; i < H.Length; i++)
            {
                while(wallHeight > H[i] && st.Count > 0)
                {
                    b = (int)st.Pop();;
                    wallHeight -= b;
                }

                if (wallHeight < H[i])
                {
                    counter++;
                    b = H[i] - wallHeight;
                    wallHeight += b;
                    st.Push(b);
                } 
            }

            return counter;
        }
    }
}