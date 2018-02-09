using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algos.BinaryTree;
using NUnit.Framework;

namespace Tests.BinaryTree
{
    [TestFixture]
    public class MaxSumPathPostOrderTests
    {
        protected MaxSumPathPostOrder Target { get; set; }
        [SetUp]
        public void TestSetUp()
        {
            Target = new MaxSumPathPostOrder();
        }


        [Test]
        public void  MaxSumPathPostOrder_Returns7()
        {



            //  1
            // / \
            //1   1
            // \ / \
            //  11  1
            //     /
            //    1
            //     \
            //      1

            var root = new TreeNode() { val = 1 };
            root.left = new TreeNode() { val = 1 };
            root.left.right = new TreeNode() { val = 1 };

            root.right = new TreeNode() { val = 1 };
            root.right.left = new TreeNode(1);
            root.right.right = new TreeNode(1);
            root.right.right.left = new TreeNode(1);
            root.right.right.left.right = new TreeNode(1);

            Assert.AreEqual(7, Target.MaxPathSum(root));
        }

        [Test]
        public void  MaxSumPathPostOrder_Returns6()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            Assert.AreEqual(6, Target.MaxPathSum(root));
        }

        [Test]
        public void  MaxSumPathPostOrder_HandlesNullRoot()
        {
            Assert.AreEqual(0, Target.MaxPathSum(null));
        }

        [Test]
        public void  MaxSumPathPostOrder_HandlesChildlessRoot()
        {
            var root = new TreeNode(10);
            Assert.AreEqual(10, Target.MaxPathSum(root));
        }

        [Test]
        public void  MaxSumPathPostOrder_Returns3()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);


            Assert.AreEqual(3, Target.MaxPathSum(root));
        }

        [Test]
        public void  MaxSumPathPostOrder_Returns4()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(3);


            Assert.AreEqual(4, Target.MaxPathSum(root));
        }

        [Test]
        public void  MaxSumPathPostOrder_LesserChild_ReturnsParent()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(-1);


            Assert.AreEqual(2, Target.MaxPathSum(root));
        }

        [Test]
        public void  MaxSumPathPostOrder_GreaterChild_ReturnsChild()
        {
            var root = new TreeNode(-1);
            root.left = new TreeNode(2);


            Assert.AreEqual(2, Target.MaxPathSum(root));
        }

        //breadth first input: [9,6,-3,null,null,-6,2,null,null,2,null,-6,-6,-6]
        [Test]
        public void  MaxSumPathPostOrder_Returns16()
        {


            var root = new TreeNode(9);
            root.left = new TreeNode(6);

            root.right = new TreeNode(-3);
            root.right.left = new TreeNode(-6);

            root.right.right = new TreeNode(2);
            root.right.right.left = new TreeNode(2);
            root.right.right.left.left = new TreeNode(-6);
            root.right.right.left.left.left = new TreeNode(-6);
            root.right.right.left.right = new TreeNode(-6);

            Assert.AreEqual(16, Target.MaxPathSum(root));

        }

        //// "timeout exceeded" error on LeetCode: https://leetcode.com/problems/binary-tree-maximum-path-sum/description/
        //[Test]
        //public void  MaxSumPathPostOrder_HandlesLargeInput()
        //{
          
        //    var parser = new LeetCodeParser();
        //    var tree = parser.Parse(Properties.Resources. MaxSumPathPostOrder_LargeInput);
        //}
    }
}
