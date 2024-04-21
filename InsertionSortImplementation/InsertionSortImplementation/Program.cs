using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 3, 8, 4, 2 };
        InsertionSort(arr);

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    public static void InsertionSort<T>(T[] arr, IComparer<T> comparer = null) where T : IComparable
    {
        if (comparer == null)
        {
            comparer = Comparer<T>.Default;
        }

        for (int i = 1; i < arr.Length; i++)
        {
            T key = arr[i];
            int j = i - 1;

            while (j >= 0 && comparer.Compare(arr[j], key) > 0)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}