namespace ConsoleApp
{
    public class Leader
    {
        public int slowLeader(int[] A){
            int leader = -1;
            int count = 0;
            int candidate = 0;

            for (int i = 0; i < A.Length; i++)
            {
                candidate = A[i];
                count = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] == candidate)
                    {
                        count++;
                    }
                }
                
                if(count>A.Length/2)
                    leader = candidate;
            }

            return candidate;
        }

        public int fastLeader(int[] A){
            int leader = -1;
            System.Array.Sort(A);
            int candidate = A[A.Length/2];
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] == candidate)
                    count++;
            }

            if (count > A.Length/2)
            {
                leader = candidate;
            }

            return leader;
        }
    
        public int stackLeader(int[] A){
            int leader = -1;
            int candidate = 0;
            int count = 0;
            int first = 0;
            int second = 0;
            System.Collections.Stack st = new System.Collections.Stack();

            for (int i = 0; i < A.Length; i++)
            {
                st.Push(A[i]);

                if (st.Count > 1)
                {
                    first = (int)st.Pop();
                    second = (int)st.Pop();

                    if (first == second)
                    {
                        st.Push(second);
                        st.Push(first);
                    }
                }
            }

            if (st.Count > 0)
            {
                candidate = (int)st.Pop();

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == candidate)
                    {
                        count++;
                    }
                }

                if (count > A.Length/2)
                {
                    leader = candidate;
                }
            }

            return leader;

        }
    }
}