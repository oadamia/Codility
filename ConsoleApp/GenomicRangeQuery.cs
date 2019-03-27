namespace ConsoleApp
{
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];
            int[,] genoms = new int[4, S.Length + 1];
            int fromIndex = 0;
            int toIndex = 0;
            int a,b,c,d;

            for (int i = 0; i < S.Length; i++)
            {
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                switch (S[i])
                {
                    case 'A':
                        a = 1;;
                        break;
                    case 'C':
                        b = 1;;
                        break;
                    case 'G':
                        c = 1;;
                        break;
                    case 'T':
                        d = 1;
                        break;
                    default:
                        throw new System.Exception("out of range");
                }

                genoms[0, i + 1] = genoms[0, i] + a;
                genoms[1, i + 1] = genoms[1, i] + b;
                genoms[2, i + 1] = genoms[2, i] + c;
                genoms[3, i + 1] = genoms[3, i] + d;

            }

            for (int i = 0; i < P.Length; i++)
            {
                fromIndex = P[i];
                toIndex = Q[i] + 1;
                if (genoms[0, toIndex] - genoms[0, fromIndex] > 0)
                    result[i] = 1;
                else if (genoms[1, toIndex] - genoms[1, fromIndex] > 0)
                    result[i] = 2;
                else if (genoms[2, toIndex] - genoms[2, fromIndex] > 0)
                    result[i] = 3;
                else if (genoms[3, toIndex] - genoms[3, fromIndex] > 0)
                    result[i] = 4;
            }


            return result;
        }
    }
}