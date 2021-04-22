using System;
using ConsoleApp1.DataStructure;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* 124.求二叉树中最大路径和 test */
             TreeNode treeNode124 = new TreeNode(-10, 
                new TreeNode(9), new TreeNode(20, 
                    new TreeNode(15), new TreeNode(7)));
            int num = TreeLearn.Get124Answer(treeNode124);
            Console.WriteLine($"124 answer is {num}");
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}