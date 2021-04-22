using System;

namespace ConsoleApp1.DataStructure
{
    public static class TreeLearn
    {
        #region 124. 二叉树中的最大路径和

        // 124. 二叉树中的最大路径和
        // 路径 被定义为一条从树中任意节点出发，沿父节点-子节点连接，达到任意节点的序列。同一个节点在一条路径序列中 至多出现一次 。该路径 至少包含一个 节点，且不一定经过根节点。
        // 路径和 是路径中各节点值的总和。
        // 给你一个二叉树的根节点 root ，返回其 最大路径和 。
        // 示例 1：
        // 输入：root = [1,2,3]
        // 输出：6
        // 解释：最优路径是 2 -> 1 -> 3 ，路径和为 2 + 1 + 3 = 6
        // 示例 2：
        // 输入：root = [-10,9,20,null,null,15,7]
        // 输出：42
        // 解释：最优路径是 15 -> 20 -> 7 ，路径和为 15 + 20 + 7 = 42
        // 提示：
        // 树中节点数目范围是 [1, 3 * 104]
        // -1000 <= Node.val <= 1000
        private static int _ans124 = int.MinValue;

        public static int Get124Answer(TreeNode root)
        {
            MaxPathSum(root);
            return _ans124;
        }

        private static int MaxPathSum(TreeNode root)
        {
            if (root == null) return 0;
            int left = Math.Max(0, MaxPathSum(root.left));
            int right = Math.Max(0, MaxPathSum(root.right));
            _ans124 = Math.Max(_ans124, left + right + root.val);
            return Math.Max(left, right) + root.val;
        }

        #endregion

        #region 105. 从前序与中序遍历序列构造二叉树
        
        // 105. 从前序与中序遍历序列构造二叉树
        // 根据一棵树的前序遍历与中序遍历构造二叉树。
        // 注意:
        // 你可以假设树中没有重复的元素。
        // 例如，给出
        //      前序遍历 preorder = [3,9,20,15,7]
        //      中序遍历 inorder = [9,3,15,20,7]
        // 返回如下的二叉树：
        //   3
        //  / \
        // 9  20
        //   /  \
        //  15   7

        public static TreeNode Get105Answer(int[] preorder, int[] inorder)
        {
            BuildTree105(preorder, 0, preorder.Length, inorder, 0, inorder.Length);
            return null;
        }

        private static TreeNode BuildTree105(int[] preorder, int pStart, int pEnd, int[] inorder, int iStart, int iEnd)
        {
            // preorder 为空，直接返回 null
            if (pStart == pEnd) {
                return null;
            }

            int rootVal = preorder[pStart];
            TreeNode root = new TreeNode(rootVal);
            return null;
        }
        
        #endregion
    }
}