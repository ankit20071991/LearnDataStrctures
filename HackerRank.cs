using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class HackerRank
    {
        public static Stack<int> stack1 = new Stack<int>();

        public static Stack<int> stack2 = new Stack<int>();

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

        public static int SherlockHolmesProblem(int input)
        {
            int numberOfThree = 0;
            int numberOfFives = 0;
            string result = "";

            for (int i = 1; i <= input; i++)
            {
                if (i % 5 == 0)
                {
                    if ((input - i) % 3 == 0)
                    {
                        numberOfThree += i;
                    }
                }
                else if (i % 3 == 0)
                {
                    if ((input - i) % 5 == 0)
                    {
                        numberOfFives += i;
                    }
                }
            }

            if (numberOfThree == 0 && numberOfFives == 0)
                return -1;

            if (numberOfFives > numberOfThree)
            {
                for (int i = 0; i < numberOfFives; i++)
                {
                    result += "5";
                }
                for (int i = 0; i < numberOfThree; i++)
                {
                    result += "3";
                }
            }
            else
            {
                for (int i = 0; i < numberOfThree; i++)
                {
                    result += "3";
                }
                for (int i = 0; i < numberOfFives; i++)
                {
                    result += "5";
                }
            }

            return Convert.ToInt32(result);

        }

        public static int OperationArray()
        {
            int max = 0;
            string[] arrayOpeartion = Console.ReadLine().Split(' ');
            int size = Convert.ToInt32(arrayOpeartion[0]);
            int operations = Convert.ToInt32(arrayOpeartion[1]);

            int[] array = new int[size];

            for (int i = 0; i < operations; i++)
            {
                string[] indexSummandArray = Console.ReadLine().Split(' ');
                int left = Convert.ToInt32(indexSummandArray[0]);
                int right = Convert.ToInt32(indexSummandArray[1]);
                int summand = Convert.ToInt32(indexSummandArray[2]);

                for (int j = left - 1; j < right - 1; j++)
                {
                    array[j] += summand;
                    if (array[j] > max)
                    {
                        max = array[j];
                    }
                }

            }
            return max;
        }

        public static void Enque(int data)
        {
            stack1.Push(data);
        }

        public static int Deque()
        {
            if (stack2.Count > 0)
                return stack2.Pop();

            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            return stack2.Pop();
        }
    }
}
