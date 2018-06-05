using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class SearchAlgo
    {
        public static int BinarySearch(int[] input, int searchNumber)
        {
            int low = 0;
            int high = input.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (input[mid] == searchNumber)
                    return mid;

                if (searchNumber > input[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        public static int[] BinarySearch2D(int[,] input, int searchNumber, int n)
        {
            int i = 0;
            int j = n - 1;

            while (i < n && j >= 0)
            {
                if (input[i, j] == searchNumber)
                    return new int[] { i, j };

                if (searchNumber > input[i, j])
                    i++;
                else
                    j--;
            }
            return new int[] { -1, -1 };
        }

        public static int GetOddNumberFromString(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                int j = i + 1;
                result = Convert.ToInt32(input[i]) ^ Convert.ToInt32(input[j]);
            }
            return result;
        }

    }
}
