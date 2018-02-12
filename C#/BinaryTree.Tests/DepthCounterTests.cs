using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algos.BinaryTree;

namespace Tests.BinaryTree
{

    public class DepthCounterTests
    {

        protected DepthCounter Target { get; set; }

        public DepthCounterTests()
        {
            Target = new DepthCounter();
        }

        [Fact]
        public void GetHeight_Returns0()
        {
            Assert.Equal(0, Target.GetHeight(null));
        }

        [Fact]
        public void GetHeight_Returns1()
        {
            Assert.Equal(1, Target.GetHeight(new TreeNode()));
        }

        [Fact]
        public void GetHeight_EqualChildren_Returns2()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            Assert.Equal(2, Target.GetHeight(root));
        }

        [Fact]
        public void GetHeight_LeftChild_Returns2()
        {
            var root = new TreeNode();

            root.left = new TreeNode();


            Assert.Equal(2, Target.GetHeight(root));
        }



        [Fact]
        public void GetHeight_LeftChild_Returns3()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.left.left = new TreeNode();

            Assert.Equal(3, Target.GetHeight(root));
        }

        [Fact]
        public void GetHeight_LeftChild_Returns4()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.left.right = new TreeNode();
            root.left.right.left = new TreeNode();

            Assert.Equal(4, Target.GetHeight(root));
        }

        [Fact]
        public void GetHeight_RightChild_Returns2()
        {
            var root = new TreeNode();


            root.right = new TreeNode();

            Assert.Equal(2, Target.GetHeight(root));
        }



        [Fact]
        public void GetHeight_RightChild_Returns3()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.right.left = new TreeNode();

            Assert.Equal(3, Target.GetHeight(root));
        }

        [Fact]
        public void GetHeight_RightChild_Returns4()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.right.right = new TreeNode();
            root.right.right.left = new TreeNode();

            Assert.Equal(4, Target.GetHeight(root));
        }

        [Fact]
        public void GetHeightIterative_Returns0()
        {
            Assert.Equal(0, Target.GetHeightIterative(null));
        }

        [Fact]
        public void GetHeightIterative_Returns1()
        {
            Assert.Equal(1, Target.GetHeightIterative(new TreeNode()));
        }

        [Fact]
        public void GetHeightIterative_EqualChildren_Returns2()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            Assert.Equal(2, Target.GetHeightIterative(root));
        }

        [Fact]
        public void GetHeightIterative_LeftChild_Returns2()
        {
            var root = new TreeNode();

            root.left = new TreeNode();


            Assert.Equal(2, Target.GetHeightIterative(root));
        }



        [Fact]
        public void GetHeightIterative_LeftChild_Returns3()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.left.left = new TreeNode();

            Assert.Equal(3, Target.GetHeightIterative(root));
        }

        [Fact]
        public void GetHeightIterative_LeftChild_Returns4()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.left.right = new TreeNode();
            root.left.right.left = new TreeNode();

            Assert.Equal(4, Target.GetHeightIterative(root));
        }

        [Fact]
        public void GetHeightIterative_RightChild_Returns2()
        {
            var root = new TreeNode();


            root.right = new TreeNode();

            Assert.Equal(2, Target.GetHeightIterative(root));
        }



        [Fact]
        public void GetHeightIterative_RightChild_Returns3()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.right.left = new TreeNode();

            Assert.Equal(3, Target.GetHeightIterative(root));
        }

        [Fact]
        public void GetHeightIterative_RightChild_Returns4()
        {
            var root = new TreeNode();

            root.left = new TreeNode();
            root.right = new TreeNode();

            root.right.right = new TreeNode();
            root.right.right.left = new TreeNode();

            Assert.Equal(4, Target.GetHeightIterative(root));
        }

    }
}