using System;

namespace ConsoleApp
{
    public class Brackets
    {
        //BrutForce Solution 100% Correct
        public int solution(string S)
        {
            System.Collections.Stack st = new System.Collections.Stack();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(' || S[i] == '{' || S[i] == '[')
                {
                    st.Push(S[i]);
                }
                else if (S[i] == ')' || S[i] == '}' || S[i] == ']')
                {
                    if (st.Count == 0)
                    {
                        return 0;
                    }

                    char r = (char)st.Pop();

                    if (r == '(' && S[i] != ')')
                    {
                        return 0;
                    }

                    if (r == '{' && S[i] != '}')
                    {
                        return 0;
                    }

                    if (r == '[' && S[i] != ']')
                    {
                        return 0;
                    }
                }
            }

            if (st.Count != 0)
            {
                return 0;
            }

            return 1;
        }

        //More Elegant Solution
        public int solution1(string S)
        {
            System.Collections.Stack st = new System.Collections.Stack();

            if (S.Length % 2 != 0)
                return 0;
                
            foreach (var symbol in S)
            {
                if (symbol == '(' || symbol == '{' || symbol == '[')
                    st.Push(symbol);
                else
                {
                    if (st.Count == 0)
                        return 0;
                    char last = (char)st.Pop();
                    if (!IsValidPair(last, symbol))
                        return 0;
                }
            }

            if (st.Count != 0)
                return 0;

            return 1;
        }

        private bool IsValidPair(char left, char right)
        {
            if (left == '(' && right == ')')
                return true;
            if (left == '{' && right == '}')
                return true;
            if (left == '[' && right == ']')
                return true;
            return false;
        }
    }
}