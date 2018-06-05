using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS101
{
    public class TreeDS
    {
        public BTNode root = null;

        public static void PreOrder(BTNode root)
        {
            if (root == null)
                return;
            Console.Write(root.data + "->");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public static void InOrder(BTNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            Console.Write(root.data + "->");
            InOrder(root.right);
        }

        public static void PostOrder(BTNode root)
        {
            if (root == null)
                return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data + "->");
        }

        public static int HeightOfBT(BTNode root)
        {
            if (root == null)
                return 0;

            int heightLeft = HeightOfBT(root.left);
            int heightRight = HeightOfBT(root.right);

            return Max(heightLeft, heightRight) + 1;
        }

        public static int CountOfBT(BTNode root)
        {
            if (root == null)
                return 0;

            int countLeft = CountOfBT(root.left);
            int countRight = CountOfBT(root.right);

            return countLeft + countRight + 1;
        }

        public static int MaxNode(BTNode root)
        {
            if (root == null)
                return 0;

            int maxLeft = MaxNode(root.left);
            int maxRight = MaxNode(root.right);

            return Max(Max(maxLeft, maxRight), root.data);
        }

        public static int NumberOfLeaf(BTNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            int numLeft = NumberOfLeaf(root.left);
            int numRight = NumberOfLeaf(root.right);

            return numLeft + numRight;
        }

        public static BTNode SearchNode(BTNode root, int data)
        {
            if (root == null)
                return null;

            if (root.data == data)
                return root;

            BTNode nodeLeft = SearchNode(root.left, data);
            BTNode nodeRight = SearchNode(root.right, data);

            if (nodeRight != null)
                return nodeRight;

            return nodeLeft;
        }

        public static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }

        //BT LCA
        public static BTNode LCA(BTNode root, int alpha, int beeta)
        {
            if (root == null)
                return null;
            if (root.data == alpha)
                return root;
            if (root.data == beeta)
                return root;

            BTNode LeftLCA = LCA(root.left, alpha, beeta);
            BTNode RIghtLCA = LCA(root.right, alpha, beeta);

            if (RIghtLCA != null && LeftLCA != null)
                return root;

            return (LeftLCA != null) ? LeftLCA : RIghtLCA;
        }
        //BST LCA
        public static BTNode BSTLCA(BTNode node, int n1, int n2)
        {
            if (node == null)
                return null;

            // If both n1 and n2 are smaller than root, then LCA lies in left
            if (node.data > n1 && node.data > n2)
                return BSTLCA(node.left, n1, n2);

            // If both n1 and n2 are greater than root, then LCA lies in right
            if (node.data < n1 && node.data < n2)
                return BSTLCA(node.right, n1, n2);

            return node;
        }


        //This will work for some cases but few scenarios it will fail
        public static bool IsBST(BTNode root)
        {
            if (root == null)
                return false;
            if (root.left != null && root.left.data > root.data)
                return false;
            if (root.right != null && root.right.data < root.data)
                return false;

            return true;
        }

        //Perfect code for isbst
        public static bool PerfectIsBST(BTNode root, int min, int max)
        {
            if (root == null)
                return true;
            if (root.data < min)
                return false;
            if (root.data > max)
                return false;

            return PerfectIsBST(root.left, min, root.data) && PerfectIsBST(root.right, root.data, max);
        }

        public static BTNode InsertBST(BTNode root, int data)
        {
            BTNode newNode = new BTNode(data);

            if (root == null)
                return newNode;

            if (data < root.data && root.left == null)
                root.left = newNode;

            if (data > root.data && root.right == null)
                root.right = newNode;

            if (data < root.data)
                InsertBST(root.left, data);

            if (data > root.data)
                InsertBST(root.right, data);

            return root;
        }
    }

    public class BTNode
    {
        public int data;
        public BTNode left = null;
        public BTNode right = null;

        public BTNode(int data)
        {
            this.data = data;
        }
    }
}
