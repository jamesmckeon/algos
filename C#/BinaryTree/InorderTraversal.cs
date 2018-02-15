using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos.BinaryTree
{
    public class InorderTraversal
    {

        public int[] TraverseRecursive(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            else
            {
                return TraverseRecursive(node, new List<int>());
            }
        }

        public int[] TraverseRecursiveWithClosure(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            else
            {
                var values = new List<int>();

                var traverse = new Func<TreeNode, int[]>(n =>
                {
                    if (n.left != null)
                    {
                        TraverseRecursive(n.left, values);
                    }

                    values.Add(n.val);

                    if (n.right != null)
                    {
                        TraverseRecursive(n.right, values);
                    }

                    return values.ToArray();
                });

                return traverse(node);
            }
        }

        public int[] TraverseRecursive(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return null;
            }
            else
            {


                if (node.left != null)
                {
                    TraverseRecursive(node.left, values);
                }

                values.Add(node.val);

                if (node.right != null)
                {
                    TraverseRecursive(node.right, values);
                }

                return values.ToArray();
            }
        }

        public int[] TraverseIterative(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            else
            {
                var s = new Stack<TreeNode>();
                var vals = new List<int>();

                while (node != null || s.Count > 0)
                {

                    while (node != null)
                    {
                        s.Push(node);
                        node = node.left;
                    }

                    if (node == null && s.Count > 0)
                    {
                        node = s.Pop();
                        vals.Add(node.val);
                        node = node.right;
                    }

                }

                return vals.ToArray();
            }
        }
    }
}
