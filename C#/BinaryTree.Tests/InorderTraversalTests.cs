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

        /*   [Fact]
          public void TraverseRecursive_Case1()
          {
              Assert.Null(Target.TraverseRecursive(null));
          }

          [Fact]
          public void TraverseRecursive_Case2()
          {
              var root = new TreeNode(15);
              Assert.Equal(new int[] { 15 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case3()
          {
              var root = CaseBuilder.GetCase3();
              Assert.Equal(new int[] { 7, 15 }, Target.TraverseRecursive(root));

          }

          [Fact]
          public void TraverseRecursive_Case4()
          {
              var root = CaseBuilder.GetCase4();
              Assert.Equal(new int[] { 15, 25 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case5()
          {
              var root = CaseBuilder.GetCase5();
              Assert.Equal(new int[] { 7, 15, 25 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case6()
          {
              var root = CaseBuilder.GetCase6();
              Assert.Equal(new int[] { 5, 7, 15 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case7()
          {
              var root = CaseBuilder.GetCase7();
              Assert.Equal(new int[] { 3, 5, 7, 15 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case8()
          {
              var root = CaseBuilder.GetCase8();
              Assert.Equal(new int[] { 3, 5, 6, 7, 15 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case9()
          {
              var root = CaseBuilder.GetCase9();
              Assert.Equal(new int[] { 3, 4, 5, 7, 15 }, Target.TraverseRecursive(root));
          }

          [Fact]
          public void TraverseRecursive_Case10()
          {
              var root = CaseBuilder.GetCase10();
              Assert.Equal(new int[] { 3, 4, 5, 6, 7, 15 }, Target.TraverseRecursive(root));
          } */

        [Theory]
        [InlineData(1, null)]
        [InlineData(2, new int[] { 15 })]
        [InlineData(3, new int[] { 7, 15 })]
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

        [Theory]
        [InlineData(1, null)]
        [InlineData(2, new int[] { 15 })]
        [InlineData(3, new int[] { 7, 15 })]
        public void TraverseRecursiveWithClosure_ReturnsExpected(int testCaseNumber, int[] expected)
        {
            var root = CaseBuilder.GetCase(testCaseNumber);

            if (expected == null)
            {
                Assert.Null(Target.TraverseRecursiveWithClosure(root));
            }
            else
            {
                Assert.Equal(expected, Target.TraverseRecursiveWithClosure(root));

            }

        }
    }
}