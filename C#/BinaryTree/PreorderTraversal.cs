using System;
using System.Collections.Generic;
using System.Linq;

namespace Algos.BinaryTree
{
    public class PreorderTraversal
    {

        public int[] TraverseRecursive(TreeNode node)
        {
            return TraverseRecursive(node, new List<int>());
        }

        public int[] TraverseRecursive(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return null;
            }
            else
            {

                values.Add(node.val);

                if (node.left != null)
                {
                    TraverseRecursive(node.left, values);
                }

                if (node.right != null)
                {
                    TraverseRecursive(node.right, values);
                }

                return values.ToArray();


            }
        }

        public int[] TraverseIterative(TreeNode node)
        {
            throw new NotImplementedException();
        }
    }
}
