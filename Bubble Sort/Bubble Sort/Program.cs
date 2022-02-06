using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort(25, 17, 8, 5, 45, 32, 14, 12, 4, 1);
        }

       static void BubbleSort(params double [] arr)
        {
            double temp;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-(i+1); j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
