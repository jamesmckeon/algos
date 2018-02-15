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
    public class InorderTraversalTests
    {

        protected InorderTraversal Target { get; set; }
        protected TestCaseBuilder CaseBuilder { get; set; }
        public InorderTraversalTests()
        {
            Target = new InorderTraversal();
            CaseBuilder = new TestCaseBuilder();
        }


        [Theory]
        [InlineData(1, null)]
        [InlineData(2, new int[] { 15 })]
        [InlineData(3, new int[] { 7, 15 })]
        [InlineData(4, new int[] { 15, 25 })]
        [InlineData(5, new int[] { 7, 15, 25 })]
        [InlineData(6, new int[] { 5, 7, 15 })]
        [InlineData(7, new int[] { 3, 5, 7, 15 })]
        [InlineData(8, new int[] { 3, 5, 6, 7, 15 })]
        [InlineData(9, new int[] { 3, 4, 5, 7, 15 })]
        [InlineData(10, new int[] { 3, 4, 5, 6, 7, 15 })]
        [InlineData(11, new int[] { 3, 4, 5, 6, 7, 15, 25 })]
        [InlineData(12, new int[] { 3, 4, 5, 6, 7, 15, 20, 25 })]
        [InlineData(13, new int[] { 3, 4, 5, 6, 7, 15, 20, 25, 30 })]
        [InlineData(14, new int[] { 3, 4, 5, 6, 7, 15, 20, 22, 25, 30 })]
        [InlineData(15, new int[] { 3, 4, 5, 6, 7, 15, 20, 22, 25, 28, 30 })]
        public void Traverse_ReturnsExpected(int testCaseNumber, int[] expected)
        {
            var root = CaseBuilder.GetCase(testCaseNumber);


            //for each traverse method, assert every test case defined by InlineData attribute


            var methods = new List<Func<TreeNode, int[]>>();
            methods.Add((node) => Target.TraverseIterative(node));
            methods.Add((node) => Target.TraverseRecursive(node));
            methods.Add((node) => Target.TraverseRecursiveWithClosure(node));

            foreach (var method in methods)
            {
                if (expected == null)
                {
                    Assert.Null(method(root));
                }
                else
                {
                    Assert.Equal(expected, method(root));

                }

            }

        }
    }
}