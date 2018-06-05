using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class HackerRank
    {
        public static int[] LeftRotate(int[] inputArray, int rotationCount)
        {
            int index;
            // 1 2 3 4 5
            //5 1 2 3 4
            int[] b = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                index = i - rotationCount;
                if (index < 0)
                {
                    index = inputArray.Length + index;
                }
                b[index] = inputArray[i];
            }

            return b;
        }
        public static int[] SparseArray(string[] strings, string[] Queries)
        {
            int[] result = new int[strings.Length];

            for (int i = 0; i < Queries.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < strings.Length; j++)
                {

                    if (Queries[i] == strings[j])
                    {
                        counter++;
                    }
                }
                result[i] = counter;
            }
            return result;
        }
    }
}
