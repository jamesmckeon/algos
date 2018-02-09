using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algos.BinaryTree;
namespace Tests.BinaryTree
{

    public class LeetCodeParserTests
    {
        protected LeetCodeParser Target { get; set; }
        public LeetCodeParserTests()
        {
            Target = new LeetCodeParser();
        }
        [Fact]
        public void Parse_Case1_ReturnsExpected()
        {

            string input = "[1,2,3,4,null,5,null,6,7,null,8]";

            TreeNode expected = new TreeNode(1);
            expected.left = new TreeNode(2);
            expected.right = new TreeNode(3);
            expected.left.left = new TreeNode(4);
            expected.left.right = null;
            expected.right.left = new TreeNode(5);
            expected.right.right = null;
            expected.left.left.left = new TreeNode(6);
            expected.left.left.right = new TreeNode(7);
            expected.right.left.left = null;
            expected.right.left.right = new TreeNode(8);

            Assert.True(TreesEqual(expected, Target.Parse(input)));
        }

        bool NodesEqual(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            else if (a == null || b == null)
            {
                return false;
            }
            else
            {
                return a.val == b.val;
            }
        }
        bool TreesEqual(TreeNode a, TreeNode b)
        {

            var nodeA = a;
            var nodeB = b;

            var qA = new Queue<TreeNode>();
            var qB = new Queue<TreeNode>();

            qA.Enqueue(nodeA);
            qB.Enqueue(nodeB);

            while (qA.Count > 0)
            {
                nodeA = qA.Dequeue();

                if (qB.Count > 0)
                {
                    nodeB = qB.Dequeue();

                    if (!NodesEqual(nodeB, nodeA))
                    {
                        return false;
                    }

                    if (nodeB != null)
                    {
                        qB.Enqueue(nodeB.left);
                        qB.Enqueue(nodeB.right);
                    }


                }
                else
                {
                    return false;
                }

                if (nodeA != null)
                {
                    qA.Enqueue(nodeA.left);
                    qA.Enqueue(nodeA.right);
                }


            }

            if (qB.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


    }
}
