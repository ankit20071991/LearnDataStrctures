using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class SortingDS
    {
        public static void Swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
        public static int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        Swap(input, j, j + 1);
                    }
                }
            }
            return input;
        }

        public static int[] SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }

                Swap(input, min, i);
            }
            return input;
        }

        public static int[] InsertionSort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int temp = input[i];
                int j = i - 1;

                while (j >= 0 && input[j] > temp)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = temp;
            }
            return input;
        }
    }
}
