using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.BinaryTree
{
    /// <summary>
    /// Provides methods for parsing Binary Trees using the LeetCode array input/breadth-first format
    /// </summary>
   public class LeetCodeParser
    {
        public TreeNode Parse(string input)
        {
            if (input == null || input.Length == 0)
            {
                return null;
            }

            var vals = input.Replace("[", string.Empty).Replace("]", string.Empty).Split(",".ToCharArray());

            var q = new Queue<TreeNode>();
            var root = new TreeNode(int.Parse(vals[0]));
            TreeNode node = null;
            int i = 1;

            q.Enqueue(root);

            while (q.Count > 0 && i < vals.Length)
            {
                node = q.Dequeue();


                if (vals[i] != "null")
                {
                    node.left = new TreeNode(int.Parse(vals[i]));
                    q.Enqueue(node.left);
                }

                if (((i+1) < vals.Length) &&vals[i + 1] != "null")
                {
                    node.right = new TreeNode(int.Parse(vals[i + 1]));
                    q.Enqueue(node.right);
                }

                i += 2;
            }

            return root;
        }
    }
}
