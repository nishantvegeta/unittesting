using System;

namespace testunit
{
    public class SortingService
    {
        public int[] BubbleSort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

    }
}
