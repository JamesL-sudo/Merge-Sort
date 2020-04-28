using System;

namespace merge_sort
{
    class MergeSort {
        public static void Sort()
        {
            int[] list = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int length = list.Length;
            int mid = (length + 1) / 2;
            for(int i = 0; i < mid-1; i+=2)
            {
                if (list[i] > list[i + 1])
                {
                    int temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;
                }
            }
            for(int i = mid+1; i < 9; i += 2)
            {
                int temp = list[i];
                list[i] = list[i + 1];
                list[i + 1] = temp;
            }
            for(int x = 0; x <=4; x++)
            {
                for (int i = 9; i >= 2; i--)
                {
                    if (list[i] < list[i - 2])
                    {
                        int temp = list[i - 2];
                        list[i - 2] = list[i];
                        list[i] = temp;
                    }
                }
            }
            for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine(list[i]);
            }
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            MergeSort.Sort();
        }
    }
}
