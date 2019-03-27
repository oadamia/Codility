using System;
using static System.Console;

namespace ConsoleApp
{
    public class SortAlgorithms
    {
        
    }

    public class QuickSortAlgorithm
    {
        public void quickSort(int[] A,int lo,int hi){
            int p;
            if (lo < hi)
            {
                p = partition(A,lo,hi);
                quickSort(A,lo,p-1);
                quickSort(A,p+1,hi);
            }

        }

        private int partition(int[] A,int lo,int hi){
            WriteLine("[{2}] low:{0} High:{1}",lo,hi,string.Join(", ",A));
            int pivot  = A[hi];
            int i = lo;
            for (int j = lo; j < hi; j++)
            {
                if (A[j]<pivot)
                {
                    swap(A,i,j);
                    i++;
                }
            }
            swap(A,i,hi);
            return i;
        }

        private void swap(int[] A, int i, int j)
        {
            int tmp = A[i];
            A[i] = A[j];
            A[j] = tmp;
            WriteLine("[{2}] from:{0} to:{1}",i,j,string.Join(", ",A));
        }
    }

    public class MergeSort
    {
        public void TopDownMergeSort(int[] a,int[] b,int n)
        {
            CopyArray(a,0,n,b);
            TopDownSplitMerge(b,0,n,a);
        }

        private void TopDownSplitMerge(int[] b, int iBegin, int iEnd, int[] a)
        {
            if (iEnd - iBegin < 2)
                return;
            int iMiddle = (iEnd + iBegin)/2;

            TopDownSplitMerge(a,iBegin,iMiddle,b);
            TopDownSplitMerge(a,iMiddle,iEnd,b);

            TopDownMerge(a,iBegin,iMiddle,iEnd,b);

            
        }

        private void TopDownMerge(int[] a, int iBegin, int iMiddle, int iEnd, int[] b)
        {
            int i = iBegin;
            int j = iMiddle;

            for (int k = iBegin; k < iEnd; k++)
            {
                if (i < iMiddle && (j >= iEnd || a[i] <= a[j]))
                {
                    b[k] = a[i];
                    i++;
                } else {
                    b[k] = a[j];
                    j++;
                }
            }
        }

        private void CopyArray(int[] a, int iBegin, int iEnd, int[] b)
        {
            for (int i = iBegin; i < iEnd; i++)
            {
                b[i] = a[i];
            }
        }
    }
}