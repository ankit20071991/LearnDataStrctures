using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class MergeProblems
    {
        public static int[] MergeArray(int[] array1, int[] array2)
        {
            int n1 = array1.Length;
            int n2 = array2.Length;
            int[] result = new int[n1 + n2];
            int t1 = 0;
            int t2 = 0;
            int t3 = 0;

            while (t1 < n1 && t2 < n2)
            {
                if (array1[t1] < array2[t2])
                {
                    result[t3] = array1[t1];
                    t1++;
                }
                else
                {
                    result[t3] = array2[t2];
                    t2++;
                }
                t3++;
            }

            while (t1 < n1)
            {
                result[t3] = array1[t1];
                t3++;
                t1++;
            }

            while (t2 < n2)
            {
                result[t3] = array2[t2];
                t3++;
                t2++;
            }

            return result;

        }

        public static int MinimumNumberOfPlatform(int[] t1, int[] t2)
        {
            List<Train> trainList = new List<Train>();
            foreach (var t in t1)
            {
                trainList.Add(new Train(t, "A"));
            }
            foreach (var t in t2)
            {
                trainList.Add(new Train(t, "D"));
            }

            trainList.Sort();

            int counter = 0;
            int max = 0;

            foreach (var train in trainList)
            {
                if (train.type == "A")
                    counter++;
                else
                    counter--;

                if (counter > max)
                    max = counter;
            }

            return max;
        }

        public static int MaxKnapsack(int[] profits, int[] wts, int wt)
        {
            List<KanpItem> kanpList = new List<KanpItem>();
            for (var t = 0; t < wts.Length; t++)
            {
                kanpList.Add(new KanpItem(wts[t], profits[t], profits[t] / wts[t]));
            }

            kanpList.Sort();
            int knapSum = 0;

            foreach (var kanpItem in kanpList)
            {
                if (kanpItem.value < wt)
                {
                    knapSum += kanpItem.profitPerItem * kanpItem.value;
                    wt -= kanpItem.value;
                }
                else
                {
                    knapSum += kanpItem.profitPerItem * wt;
                    wt = 0;
                    break;
                }
            }

            return knapSum;
        }
    }

    class Train : IComparable
    {
        public int time;
        public string type;

        public Train(int time, string type)
        {
            this.time = time;
            this.type = type;
        }

        public int CompareTo(object obj)
        {
            return this.time - ((Train)obj).time;
        }
    }

    class KanpItem : IComparable
    {
        public int value;
        public int profit;
        public int profitPerItem;

        public KanpItem(int value, int profit, int profitPerItem)
        {
            this.value = value;
            this.profit = profit;
            this.profitPerItem = profitPerItem;
        }

        public int CompareTo(object obj)
        {
            return ((KanpItem)obj).profitPerItem - this.profitPerItem;
        }
    }
}
