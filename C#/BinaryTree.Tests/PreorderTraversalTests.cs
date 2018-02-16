using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algos.BinaryTree;
using Algos.BinaryTree.Tests.Helpers;

namespace Algos.BinaryTree.Tests
{
    public class PreorderTraversalTests
    {

        protected PreorderTraversal Target { get; set; }
        protected TestCaseBuilder CaseBuilder { get; set; }
        public PreorderTraversalTests()
        {
            Target = new PreorderTraversal();
            CaseBuilder = new TestCaseBuilder();
        }


        [Theory]
        [InlineData(1, null)]
        [InlineData(2, new int[] { 15 })]
        [InlineData(3, new int[] { 15, 7 })]
        [InlineData(4, new int[] { 15, 25 })]
        [InlineData(5, new int[] { 15, 7, 25 })]
        [InlineData(6, new int[] { 15, 7, 5 })]
        [InlineData(7, new int[] { 15, 7, 5, 3 })]
        [InlineData(8, new int[] { 15, 7, 5, 3, 6 })]
        [InlineData(9, new int[] { 15, 7, 5, 3, 4 })]
        [InlineData(10, new int[] { 15, 7, 5, 3, 4, 6 })]
        [InlineData(11, new int[] { 15, 7, 5, 3, 4, 6, 25 })]
        [InlineData(12, new int[] { 15, 7, 5, 3, 4, 6, 25, 20 })]
        [InlineData(13, new int[] { 15, 7, 5, 3, 4, 6, 25, 20, 30 })]
        [InlineData(14, new int[] { 15, 7, 5, 3, 4, 6, 25, 20, 22, 30 })]
        [InlineData(15, new int[] { 15, 7, 5, 3, 4, 6, 25, 20, 22, 30, 28 })]
        public void TraverseIterative_ReturnsExpected(int testCaseNumber, int[] expected)
        {
            var root = CaseBuilder.GetCase(testCaseNumber);

            if (expected == null)
            {
                Assert.Null(Target.TraverseIterative(root));
            }
            else
            {
                Assert.Equal(expected, Target.TraverseIterative(root));

            }

        }

        [Theory]
        [InlineData(1, null)]
        [InlineData(2, new int[] { 15 })]
        [InlineData(3, new int[] { 15, 7 })]
        [InlineData(4, new int[] { 15, 25 })]
        [InlineData(5, new int[] { 15, 7, 25 })]
        [InlineData(6, new int[] { 15, 7, 5 })]
        [InlineData(7, new int[] { 15, 7, 5, 3 })]
        [InlineData(8, new int[] { 15, 7, 5, 3, 6 })]
        [InlineData(9, new int[] { 15, 7, 5, 3, 4 })]
        [InlineData(10, new int[] { 15, 7, 5, 3, 4, 6 })]
        [InlineData(11, new int[] { 15, 7, 5, 3, 4, 6, 25 })]
        [InlineData(12, new int[] { 15, 7, 5, 3, 4, 6, 25, 20 })]
        [InlineData(13, new int[] { 15, 7, 5, 3, 4, 6, 25, 20, 30 })]
        [InlineData(14, new int[] { 15, 7, 5, 3, 4, 6, 25, 20, 22, 30 })]
        [InlineData(15, new int[] { 15, 7, 5, 3, 4, 6, 25, 20, 22, 30, 28 })]
        public void TraverseRecursive_ReturnsExpected(int testCaseNumber, int[] expected)
        {
            var root = CaseBuilder.GetCase(testCaseNumber);

            if (expected == null)
            {
                Assert.Null(Target.TraverseRecursive(root));
            }
            else
            {
                Assert.Equal(expected, Target.TraverseRecursive(root));

            }


        }
    }
}