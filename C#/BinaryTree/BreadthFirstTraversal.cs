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
            if (node == null)
            {
                return null;
            }
            else
            {
                var values = new List<int>();
                values.Add(node.val);
           return     TraverseRecursive(node, values);

                
            }
        }

        public int[] TraverseRecursive(TreeNode node, IList<int> values)
        {

                if (node.left != null )
                {
                values.Add(node.left.val);
                }

                if ( node.right != null)
                {
                values.Add(node.right.val);
                  }

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

                   if(node.right != null)
                    {
                        q.Enqueue(node.right);
                    }


                }

                return ret.ToArray();

            }
        }
    }
}
