using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.BinaryTree
{
    public class BreadthFirstTraversal
    {
        public int[] TraverseRecursive(TreeNode node)
        {
            throw new NotImplementedException();
        }


        public int[] TraverseIterative(TreeNode node)
        {
            if (node == null)
            {
                return null;
            }
            else
            {
                var q = new Queue<TreeNode>();
                var ret = new List<int>();

                q.Enqueue(node);

                while (q.Count > 0)
                {
                    node = q.Dequeue();
                    ret.Add(node.val);

                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }


                }

                return ret.ToArray();

            }
        }
    }
}
