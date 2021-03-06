﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algos.BinaryTree;
using Xunit;

namespace Algos.BinaryTree.Tests
{

    public class MaxSumPathTests
    {
        protected MaxSumPath Target { get; set; }


        public MaxSumPathTests()
        {
            Target = new MaxSumPath();
        }

        [Fact]
        public void MaxPathSum_Returns7()
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

            Assert.Equal(7, Target.MaxPathSum(root));
        }

        [Fact]
        public void MaxPathSum_Returns6()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            Assert.Equal(6, Target.MaxPathSum(root));
        }

        [Fact]
        public void MaxPathSum_HandlesNullRoot()
        {
            Assert.Equal(0, Target.MaxPathSum(null));
        }

        [Fact]
        public void MaxPathSum_HandlesChildlessRoot()
        {
            var root = new TreeNode(10);
            Assert.Equal(10, Target.MaxPathSum(root));
        }

        [Fact]
        public void MaxPathSum_Returns3()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);


            Assert.Equal(3, Target.MaxPathSum(root));
        }

        [Fact]
        public void MaxPathSum_Returns4()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(3);


            Assert.Equal(4, Target.MaxPathSum(root));
        }

        [Fact]
        public void MaxPathSum_LesserChild_ReturnsParent()
        {
            var root = new TreeNode(2);
            root.left = new TreeNode(-1);


            Assert.Equal(2, Target.MaxPathSum(root));
        }

        [Fact]
        public void MaxPathSum_GreaterChild_ReturnsChild()
        {
            var root = new TreeNode(-1);
            root.left = new TreeNode(2);


            Assert.Equal(2, Target.MaxPathSum(root));
        }

        //breadth first input: [9,6,-3,null,null,-6,2,null,null,2,null,-6,-6,-6]
        [Fact]
        public void MaxPathSum_Returns16()
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

            Assert.Equal(16, Target.MaxPathSum(root));

        }


    }
}
