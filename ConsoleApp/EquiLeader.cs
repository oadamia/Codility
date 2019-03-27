namespace ConsoleApp
{
    public class EquiLeader
    {
        //brute force solution correct 100%, performance 0%
        public int solution(int[] A)
        {
            int count = 0;
            result leader = getLeader(A, 0, A.Length - 1);
            result leaderFirst = getLeader(A, 0, 0);
            result leaderSecond = getLeader(A, 1, A.Length - 1);

            if (leaderFirst.hasLeader && leaderSecond.hasLeader && leaderFirst.leader == leaderSecond.leader)
            {
                count++;
            }

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (!leaderFirst.hasLeader || A[i] != leaderFirst.leader)
                {
                    leaderFirst = getLeader(A, 0, i);
                }

                if (!leaderSecond.hasLeader || A[i] == leaderSecond.leader)
                {
                    leaderSecond = getLeader(A, i + 1, A.Length - 1);
                }

                if (leaderFirst.hasLeader && leaderSecond.hasLeader && leaderFirst.leader == leaderSecond.leader)
                {
                    count++;
                }
            }


            return count;
        }

        //better solution correct 100% performance 50%
        public int solution1(int[] A){
            int count = 0;
            result leader = getLeader(A, 0, A.Length - 1);
            int FirstLeaderCount;
            int SecondLeaderCount;

            if (leader.hasLeader)
            {
                FirstLeaderCount = 0;
                SecondLeaderCount = leader.count;;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == leader.leader)
                    {
                        FirstLeaderCount++;
                        SecondLeaderCount--;
                    }

                    if (FirstLeaderCount > (i+1)/2 && SecondLeaderCount > (A.Length-i-1)/2)
                    {
                        count++;
                    }
                }

            } else {
                count = 0;
            }
            return count;
        }

        struct result
        {
            public bool hasLeader;
            public int leader;
            public int count;
        }

        private result getLeader(int[] B, int sIndex, int eIndex)
        {
            int candidate = 0;
            int count = 0;
            int Length = eIndex - sIndex + 1;
            int first = 0;
            int second = 0;
            result r = new result() { hasLeader = false, leader = 0, count = 0 };
            System.Collections.Stack st = new System.Collections.Stack();

            for (int i = sIndex; i <= eIndex; i++)
            {
                st.Push(B[i]);

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

                for (int i = sIndex; i <= eIndex; i++)
                {
                    if (B[i] == candidate)
                    {
                        count++;
                    }
                }

                if (count > Length / 2)
                {
                    r.hasLeader = true;
                    r.leader = candidate;
                    r.count = count;
                }
            }

            return r;
        }
    }
}