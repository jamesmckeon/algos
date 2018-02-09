using System;
using System.Text;
using System.Threading.Tasks;

namespace Algos.BinaryTree
{

    public class MaxSumPath
    {

        int max = int.MinValue;

        public int MaxPathSum(TreeNode root)
        {

            if (root == null)
            {
                return 0;
            }
            else
            {

                var nodeSum = root.val;

                if (root.left != null)
                {
                    MaxPathSum(root.left);

                    var left = MaxChildSum(root.left);

                    if (left > 0)
                    {
                        nodeSum += left;
                    }
                }


                if (root.right != null)
                {
                    MaxPathSum(root.right);

                    var right = MaxChildSum(root.right);

                    if (right > 0)
                    {
                        nodeSum += right;
                    }
                }

                if (nodeSum > max)
                {
                    max = nodeSum;
                }

            }

            return max;

        }

        public int MaxChildSum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                var maxChild = Math.Max(MaxChildSum(node.left), MaxChildSum(node.right));

                return node.val + Math.Max(0, maxChild);
            }
        }


    }

}
