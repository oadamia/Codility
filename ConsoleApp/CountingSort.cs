namespace ConsoleApp
{
    public class Sorting
    {
        public int[] SelectionSort(int[] A){
            int minimal;
            
            for (int i = 0; i < A.Length; i++)
            {
                minimal = i;
                for (int j = i + 1; j < A.Length; j++)
                    if (A[j] < A[minimal])
                        minimal = j;
            
                (A[i],A[minimal]) = (A[minimal],A[i]);
            
            }

            return A;
        }

        public int[] CountingSort(int[] A){
            int max = A[0];
            int[] Count;
            int position = 0;

            for (int i = 0; i < A.Length; i++)
                max = A[i] > max ? A[i] : max ;
            
            Count = new int[max+1];

            for (int i = 0; i < A.Length; i++)
                Count[A[i]]++;
            
            for (int i = 0; i < max+1; i++)
                for (int j = 0; j < Count[i]; j++)
                {
                    A[position] = i;
                    position++;
                }

            

            return A;
        }
    }
}