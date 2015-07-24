using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{

/*
 * Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.
 * For example:
 * Given the below binary tree and sum = 22,
 * 
 *               5
 *              / \
 *             4   8
 *            /   / \
 *           11  13  4
 *          /  \      \
 *         7    2      1
 * 
 * return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
 */

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class PathSumLinkList
    {
        public class TreeNode
        {
            public int val;
            /// <summary>
            /// start from 1
            /// </summary>
            public int index;
            public TreeNode left;
            public TreeNode right;
            public TreeNode parent;
            public TreeNode(int x) { val = x; }

            public TreeNode(int x, int i)
            {
                val = x;
                index = i;
            }
            public int CurrentPathSum;

            /// <summary>
            /// Get left child index
            /// </summary>
            /// <param name="N">totol nodes count</param>
            /// <returns></returns>
            public int GetLeftIndex(int N)
            {
                if (2 * index + 1 < N) return 2 * index + 1;
                return 0;
            }

            public int GetRightIndex(int N)
            {
                if (2 * (index + 1) < N) return 2 * (index + 1);
                return 0;
            }

            public int GetParent()
            {
                if (index > 0) return index / 2;
                return 0;
            }
        }

        public void GenerateTree(int[] nodes, ref TreeNode node)
        {
            int leftIndex = node.GetLeftIndex(nodes.Length);
            if(leftIndex != 0)
            {
                node.left = new TreeNode(nodes[leftIndex], leftIndex);
                node.left.parent = node;
                GenerateTree(nodes, ref node.left);
            }
            int rightIndex = node.GetRightIndex(nodes.Length);
            if(rightIndex != 0)
            {
                node.right = new TreeNode(nodes[rightIndex], rightIndex);
                node.right.parent = node;
                GenerateTree(nodes, ref node.right);
            }
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode currentNode = root;
            while(currentNode != null || s.Count != 0)
            {
                if (currentNode.parent != null)
                    currentNode.CurrentPathSum = currentNode.parent.CurrentPathSum + currentNode.val;
                else
                    currentNode.CurrentPathSum = currentNode.val;

                if(currentNode.CurrentPathSum == sum)
                {
                    if (currentNode.left == null && currentNode.right == null) return true; // leaf node
                    else
                    {
                        if (currentNode.left != null && currentNode.left.val == 0) s.Push(currentNode.left);
                        if (currentNode.right != null && currentNode.right.val == 0) s.Push(currentNode.right);

                        if (s.Count != 0) currentNode = s.Pop();
                        else return false;
                    }
                }
                else if(currentNode.CurrentPathSum > sum)
                {
                    if (s.Count != 0) currentNode = s.Pop();
                    else return false;
                }
                else if(currentNode.CurrentPathSum < sum)
                {
                    if(currentNode.left != null)
                    {
                        if(currentNode.left.val >= 0 && currentNode.left.val <= sum - currentNode.CurrentPathSum)
                        {
                            s.Push(currentNode.left);
                        }
                    }
                    if(currentNode.right != null)
                    {
                        if(currentNode.right.val >= 0 && currentNode.right.val <= sum - currentNode.CurrentPathSum)
                        {
                            s.Push(currentNode.right);
                        }
                    }
                    if (s.Count != 0) currentNode = s.Pop();
                    else return false;
                }
            }
            return false;
        }
    }

    public class PathSum
    {
        public bool Search(PathSumLinkList.TreeNode node, int sum, int currentSum)
        {
            if (node == null) return false;

            if (node.val < 0) return false;

            if(node.left == null && node.right == null)
            {
                return node.val + currentSum == sum;
            }

            return Search(node.left, sum, node.val + currentSum) || Search(node.right, sum, node.val + currentSum);
        }
        public bool HasPathSum(PathSumLinkList.TreeNode root, int sum)
        {
            return Search(root, sum, 0);
        }
    }

    /*
     * Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum. 
     * For example:
     *  Given the below binary tree and sum = 22,               5
     *              / \
     *             4   8
     *            /   / \
     *           11  13  4
     *          /  \    / \
     *         7    2  5   1
     * 
     * 
     * return
     * 
     * [
     *    [5,4,11,2],
     *    [5,8,4,5]
     * ]
     */
    public class PathSumII
    {
        void Search(ref List<IList<int>> res, PathSumLinkList.TreeNode node, int sum, int currentSum)
        {
            if (node == null) return;

            if (node.val < 0) return;

            if(node.right == null && node.left == null)
            {
                if(currentSum + node.val == sum)
                {
                }
            }
        }
        public IList<IList<int>> PathSum(PathSumLinkList.TreeNode root, int sum)
        {
            List<IList<int>> res = new List<IList<int>>();
        }
    }
}
