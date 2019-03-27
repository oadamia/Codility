namespace ConsoleApp
{
    public class Dominator
    {
        public int solution(int[] A) {
            candidate dominator = new candidate() {dominator = -1, index = -1};
            candidate first;
            candidate second;

            int count = 0;
            System.Collections.Stack st = new System.Collections.Stack();

            for (int i = 0; i < A.Length; i++)
            {
                st.Push(new candidate() {dominator = A[i],index=i});

                if (st.Count > 1)
                {
                    first = (candidate)st.Pop();
                    second = (candidate)st.Pop();

                    if (first.dominator == second.dominator)
                    {
                        st.Push(second);
                        st.Push(first);
                    }
                }
            }

            if (st.Count > 0)
            {
                dominator = (candidate)st.Pop();
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == dominator.dominator)
                    {
                        count++;
                    }
                }

                if (count <= A.Length/2)
                {
                    return -1;
                } 
            } else {
                return -1;
            }

            return dominator.index;
        }

        public struct candidate {
            public bool hasDominator;
            public int dominator;
            public int index;
        }
    }
}