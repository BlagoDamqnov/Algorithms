using System;

namespace Insert_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertSort(25, 12, 7, 45, 10, 9, 112, 45, 25, 145, 132, 102);
        }

        static void InsertSort(params double [] arr)
        {
            int i = 1;
            int j = i;
            double temp = 0;

            while (i<arr.Length)
            {
                j = i;
                while (j>0&&arr[j-1]>arr[j])
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
                i++;
            }
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
