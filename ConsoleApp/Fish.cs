namespace ConsoleApp
{
    public class Fish
    {
        //brute force 100% correct
        public int solution(int[] A, int[] B)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    st.Push(i);
                }
                else
                {
                    while (st.Count > 0)
                    {
                        if (A[(int)st.Peek()] < A[i])
                        {
                            st.Pop();
                        } else
                        {
                            break;
                        }
                    }
                    if (st.Count == 0)
                    {
                        count++;
                    }
                }
            }


            return count + st.Count;
        }
    }
}