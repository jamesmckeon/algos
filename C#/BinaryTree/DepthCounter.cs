using System;
using Algos.BinaryTree;
using System.Collections.Generic;
public class DepthCounter
{
    public int GetHeight(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
        }
    }

    public int GetHeightIterative(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            int height = 0;
            int nodeCount = 0;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                nodeCount = q.Count;
                height++;

                while (nodeCount > 0)
                {
                    var node = q.Dequeue();

                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }

                    nodeCount--;
                }
            }

            return height;
        }
    }

    public int GetDepth(TreeNode root, TreeNode node)
    {
        throw new NotImplementedException();
    }
}