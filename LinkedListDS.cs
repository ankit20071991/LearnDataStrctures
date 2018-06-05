using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class LinkedListDS
    {
        static LLNode head = null;

        public static LLNode InsertAtBeg(int input)
        {
            LLNode newNode = new LLNode(input);

            if (head == null)
                return head = newNode;

            newNode.next = head;
            head = newNode;

            return head;
        }

        public static LLNode InsertAtLast(int input)
        {
            LLNode newNode = new LLNode(input);

            if (head == null)
                return head = newNode;

            LLNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;

            return head;
        }

        public static LLNode DeleteAtBeg()
        {
            if (head == null)
                return null;

            return head = head.next;
        }

        public static LLNode DeleteAtLast()
        {
            if (head == null)
                return null;

            if (head.next == null)
                return null;

            LLNode temp = head;

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            temp.next = null;

            return head;
        }

        public static LLNode InsertAfter(int old, int newData)
        {
            LLNode newNode = new LLNode(newData);
            if (head == null)
                return head = newNode;

            if (head.next == null)
            {
                head.next = newNode;
                return head;
            }

            LLNode temp = head;

            while (temp != null && temp.data != old)
            {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;

            return head;
        }

        public static LLNode Reverse(LLNode node, int size)
        {
            int counter = 0;
            if (node == null)
                return null;
            LLNode current = node;
            LLNode previous = null;
            LLNode next = null;

            while (counter < size && current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                counter++;
            }
            if (next != null)
                node.next = Reverse(next, size);

            return previous;
        }

        public static LLNode InsertNth(int data, int position)
        {
            LLNode newNode = new LLNode(data);
            int counter = 0;

            if (head == null)
                return head = newNode;


            LLNode current = head;

            while (counter < position - 1 && current.next != null)
            {
                current = current.next;
            }

            newNode.next = current.next;
            current.next = newNode;

            return head;


        }

        public LLNode FlattenLinkList()
        {
            return head;
        }

        public int CountDigit(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                number /= number;
                counter++;
            }
            return counter;
        }

        public static void FindDigits()
        {

            int numberOfTests = Convert.ToInt32(Console.ReadLine());

            if (numberOfTests <= 0)
                return;

            Int64[] numberArray = new Int64[numberOfTests];
            for (int i = 0; i < numberOfTests; i++)
            {
                numberArray[i] = Convert.ToInt64(Console.ReadLine());
            }

            for (int j = 0; j < numberOfTests; j++)
            {

                Int64 rem = 0;
                string temp = "";

                if (numberArray[j] < 0)
                    continue;

                while (numberArray[j] > 0)
                {
                    rem = numberArray[j] % 3;
                    numberArray[j] = numberArray[j] / 3;
                    temp += rem.ToString();
                }
                // No need to reverse the temp as we only need to take the length of that
                //temp is having number in reverse order at given position
                Console.WriteLine(temp.Length);
            }
        }

        public static void Lexo()
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(input[0]);
            int Q = Convert.ToInt32(input[1]);
            StringBuilder A = new StringBuilder(Console.ReadLine());
            StringBuilder B = new StringBuilder(Console.ReadLine());
            int[] queries = new int[Q];

            for (int i = 0; i <= queries.Length - 1; i++)
            {
                int query = Convert.ToInt32(Console.ReadLine());
                B[query - 1] = '1';
                if (Convert.ToInt64(B.ToString()) < Convert.ToInt64(A.ToString()))
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }

        public static string IsPanagram(string input)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            int i = 1;
            string panagram = "";
            foreach (var character in input)
            {
                if (output.ContainsKey(character.ToString().ToLower()) || character == ' ')
                {
                    continue;
                }
                output.Add(character.ToString().ToLower(), i++);
            }

            if (output.Count == 26)
                panagram = "pangram";
            else
                panagram = "not pangram";

            return panagram;
        }

        public static int Anagram(string input)
        {
            if (input.Length <= 0 || input.Length % 2 != 0)
                return -1;

            char[] firstPart = input.Substring(0, input.Length / 2).ToCharArray();
            char[] secondPart = input.Substring(input.Length / 2, input.Length / 2).ToCharArray();

            Array.Sort(firstPart);
            Array.Sort(secondPart);

            int count1 = 0;
            int count2 = 0;
            int count = 0;

            foreach (var character in firstPart)
            {
                if (!secondPart.Contains(character))
                    count1++;
            }
            foreach (var character in secondPart)
            {
                if (!firstPart.Contains(character))
                    count2++;
            }

            if (count1 > count2)
            {
                count = count2;
            }
            else
            {
                count = count1;
            }
            return count;
        }

        public static string isBalanced(string s)
        {

            Stack<char> brackets = new Stack<char>();
            string result = "YES";

            foreach (var character in s)
            {
                if (character == '{' || character == '(' || character == '[')
                    brackets.Push(character);
                else if (brackets.Count > 0)
                {

                    if (character == '}')
                    {
                        if (brackets.Peek() == '}')
                        {
                            brackets.Pop();
                        }
                        else
                            return "NO";
                    }
                    if (character == ')')
                    {
                        if (brackets.Peek() == ')')
                        {
                            brackets.Pop();
                        }
                        else
                            return "NO";
                    }
                    if (character == ']')
                    {
                        if (brackets.Peek() == ']')
                        {
                            brackets.Pop();
                        }
                        else
                            return "NO";
                    }
                }
                else
                    return "NO";
            }
            return result;
        }

        public static int ValidPairs(string s)
        {
            int counter = 0;
            int temp = 0;

            foreach (var character in s)
            {
                if (character == '(')
                    temp++;
                else
                {
                    if (character == ')')
                    {
                        temp--;
                        counter++;
                    }
                }
            }
            return counter;
        }

    }
    public class LLNode
    {
        public int data;
        public LLNode next = null;

        public LLNode(int data)
        {
            this.data = data;
        }
    }
}
