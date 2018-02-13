using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algos.BinaryTree;

namespace Tests.BinaryTree
{

    public class BreadthFirstTraversalTests
    {
        BreadthFirstTraversal Target { get; set; } = new BreadthFirstTraversal();

        [Fact]
        public void TraverseRecursive_NotImplemented()
        {
            //recursive BFT is a waste of time
            var ex = Assert.Throws<NotImplementedException>(() => Target.TraverseRecursive(null));
            Assert.NotNull(ex);

        }

        [Fact]
        public void TraverseIterative_NullRoot_ReturnsNull()
        {
            Assert.Null(Target.TraverseIterative(null));
        }

        [Fact]
        public void TraverseIterative_Case1()
        {
            var expected = new int[] { 1 };
            var root = new TreeNode(1);
            Assert.Equal(expected, Target.TraverseIterative(root));
        }

        [Fact]
        public void TraverseIterative_Case2()
        {
            var expected = new int[] { 1, 2 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            Assert.Equal(expected, Target.TraverseIterative(root));
        }

        [Fact]
        public void TraverseIterative_Case3()
        {
            var expected = new int[] { 1, 2, -1 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            Assert.Equal(expected, Target.TraverseIterative(root));
        }

        [Fact]
        public void TraverseIterative_Case4()
        {
            var expected = new int[] { 1, 2, -1, 0 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);

            Assert.Equal(expected, Target.TraverseIterative(root));
        }

        [Fact]
        public void TraverseIterative_Case5()
        {
            var expected = new int[] { 1, 2, -1, 0, 4 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);

            Assert.Equal(expected, Target.TraverseIterative(root));
        }

        [Fact]
        public void TraverseIterative_Case6()
        {
            var expected = new int[] { 1, 2, -1, 0, 4, -5 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(-1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(-5);

            Assert.Equal(expected, Target.TraverseIterative(root));
        }

        [Fact]
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

            Assert.Equal(expected, Target.TraverseIterative(root));
        }
    }
}
