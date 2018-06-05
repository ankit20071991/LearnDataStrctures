﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListDS.InsertNth(3, 0);
            //LinkedListDS.InsertNth(5, 1);
            //LinkedListDS.InsertNth(4, 2);
            //LinkedListDS.InsertNth(2, 3);
            //LLNode head = LinkedListDS.InsertNth(10, 1);
            ////head = LinkedListDS.InsertAtLast(6);
            ////head = LinkedListDS.DeleteAtBeg();
            ////head = LinkedListDS.DeleteAtLast();
            ////head = LinkedListDS.InsertAfter(3, 7);
            ////head = LinkedListDS.Reverse(head, 3);

            ////LinkedListDS.Lexo();

            ////LinkedListDS.Anagram("xaxbbbxx");
            //string output = LinkedListDS.isBalanced("((()())");
            int output1 = LinkedListDS.ValidPairs("()()()");

            TreeDS tree = new TreeDS();

            tree.root = TreeDS.InsertBST(tree.root, 20);
            tree.root = TreeDS.InsertBST(tree.root, 8);
            tree.root = TreeDS.InsertBST(tree.root, 22);
            tree.root = TreeDS.InsertBST(tree.root, 4);
            tree.root = TreeDS.InsertBST(tree.root, 12);
            tree.root = TreeDS.InsertBST(tree.root, 10);
            tree.root = TreeDS.InsertBST(tree.root, 14);

            //tree.root = new BTNode(20);
            //tree.root.left = new BTNode(8);
            //tree.root.right = new BTNode(22);
            //tree.root.left.left = new BTNode(4);
            //tree.root.left.right = new BTNode(12);
            //tree.root.left.right.left = new BTNode(10);
            //tree.root.left.right.right = new BTNode(14);
            //TreeDS.PreOrder(tree.root);
            //TreeDS.InOrder(tree.root);
            //TreeDS.PostOrder(tree.root);
            int height = TreeDS.HeightOfBT(tree.root);
            int count = TreeDS.CountOfBT(tree.root);
            int max = TreeDS.MaxNode(tree.root);
            int NumberOfLeaf = TreeDS.NumberOfLeaf(tree.root);
            BTNode searchFound = TreeDS.SearchNode(tree.root, 2);
            BTNode LCA = TreeDS.LCA(tree.root, 3, 4);
            BTNode BSTLCA = TreeDS.BSTLCA(tree.root, 10, 14);
            bool isBST = TreeDS.PerfectIsBST(tree.root, Int32.MinValue, Int32.MaxValue);

            int[] result = MergeProblems.MergeArray(new int[] { 4, 5, 6, 7, 8, 9 }, new int[] { 1, 2, 3, 4 });
            int minNumPlatform = MergeProblems.MinimumNumberOfPlatform(new int[] { 900, 935, 945, 1100, 1430, 1800 }, new int[] { 915, 1145, 1105, 1200, 1815, 1900 });
            int knapSum = MergeProblems.MaxKnapsack(new int[] { 60, 120, 100 }, new int[] { 10, 30, 20 }, 50);
            int editDistance = EditDistance.EditDistanceFunction("cat", "brat", 1, 1, 1);
            int searchIndex = SearchAlgo.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1);
            int[] search2D = SearchAlgo.BinarySearch2D(new int[,] { {10, 20, 30, 40},
                        {15, 25, 35, 45},
                        {27, 29, 37, 48},
                        {32, 33, 39, 50} }, 29, 4);
            int xorResult = SearchAlgo.GetOddNumberFromString("13122344455664115");

            int[] leftArray = HackerRank.LeftRotate(new int[] { 1, 2, 3, 4, 5 }, 4);
            Console.Read();

        }
    }
}
