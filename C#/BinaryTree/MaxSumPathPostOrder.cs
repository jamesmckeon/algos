using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos.BinaryTree
{
    public class MaxSumPathPostOrder
    {

        Dictionary<TreeNode, Tuple<int, int>> nodes = new Dictionary<TreeNode, Tuple<int, int>>();
        int max = int.MinValue;
        public int MaxChildSum(TreeNode node, Tuple<int, int> childSums)
        {
            return node.val + Math.Max(Math.Max(childSums.Item1, childSums.Item2), 0);
        }

        int NodeMaxPathSum(TreeNode node, int leftChild, int rightChild)
        {
            return Math.Max(Math.Max(node.val, node.val + leftChild), Math.Max(node.val + rightChild, node.val + leftChild + rightChild));
        }
        public int MaxPathSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left == null && root.right == null)
            {
                return root.val;
            }
            else
            {
                var s1 = new Stack<TreeNode>();
                var s2 = new Stack<TreeNode>();

                s1.Push(root);

                //build post order stack
                while(s1.Count() > 0)
                {
                    var node = s1.Pop();

                    s2.Push(node);

                    if (node.left != null)
                    {
                        s1.Push(node.left);
                    }

                    if (node.right != null)
                    {
                        s1.Push(node.right);
                    }
                }

                //calculate sums
                while(s2.Count > 0)
                {
                    var node = s2.Pop();
                    var left = 0;
                    var right = 0;

                    if (node.left != null)
                    {
                        left = MaxChildSum(node.left, nodes[node.left]);
                    }

                    if (node.right != null)
                    {
                        right = MaxChildSum(node.right, nodes[node.right]);
                    }

                    nodes.Add(node, new Tuple<int, int>(left, right));

                    var nodeMax = NodeMaxPathSum(node, left, right);

                    if (nodeMax > max)
                    {
                        max = nodeMax;
                    }
                }


                return max;
            }
        }
    }

}
