using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Algos.BinaryTree;

namespace Tests.BinaryTree
{
    [TestFixture]
    class BreadthFirstTraversalTests
    {
        BreadthFirstTraversal Target { get; set; } = new BreadthFirstTraversal();

        [Test]
        public void TraverseRecursive_NullRoot_ReturnsNull()
        {
            Assert.IsNull(Target.TraverseRecursive(null));
        }

        [Test]
        public void TraverseRecursive_Case1()
        {
            var expected = new int[] { 1 };
            var root = new TreeNode(1);
            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseRecursive_Case2()
        {
            var expected = new int[] { 1,2 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseRecursive_Case3()
        {
            var expected = new int[] { 1, 2,-1 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseRecursive_Case4()
        {
            var expected = new int[] { 1, 2, -1,0 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);

            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseRecursive_Case5()
        {
            var expected = new int[] { 1, 2, -1, 0,4 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);

            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseRecursive_Case6()
        {
            var expected = new int[] { 1, 2, -1, 0, 4, -5 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(-5);

            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseRecursive_Case7()
        {
            var expected = new int[] { 1, 2, -1, 0, 4, -5, 8 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(-5);
            root.right.right = null;
            root.left.left.left = null;
            root.left.left.right = new TreeNode(8);

            CollectionAssert.AreEqual(expected, Target.TraverseRecursive(root));
        }

        [Test]
        public void TraverseIterative_NullRoot_ReturnsNull()
        {
            Assert.IsNull(Target.TraverseIterative(null));
        }

        [Test]
        public void TraverseIterative_Case1()
        {
            var expected = new int[] { 1 };
            var root = new TreeNode(1);
            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }

        [Test]
        public void TraverseIterative_Case2()
        {
            var expected = new int[] { 1, 2 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }

        [Test]
        public void TraverseIterative_Case3()
        {
            var expected = new int[] { 1, 2, -1 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }

        [Test]
        public void TraverseIterative_Case4()
        {
            var expected = new int[] { 1, 2, -1, 0 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);

            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }

        [Test]
        public void TraverseIterative_Case5()
        {
            var expected = new int[] { 1, 2, -1, 0, 4 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);

            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }

        [Test]
        public void TraverseIterative_Case6()
        {
            var expected = new int[] { 1, 2, -1, 0, 4, -5 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(-5);

            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }

        [Test]
        public void TraverseIterative_Case7()
        {
            var expected = new int[] { 1, 2, -1, 0, 4, -5, 8 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(-5);
            root.right.right = null;
            root.left.left.left = null;
            root.left.left.right = new TreeNode(8);

            CollectionAssert.AreEqual(expected, Target.TraverseIterative(root));
        }
    }
}
