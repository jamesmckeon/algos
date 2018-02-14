using System;
using Algos.BinaryTree;

namespace Algos.BinaryTree.Tests.Helpers
{
    public class TestCaseBuilder
    {

        public TreeNode GetCase(int caseNumber)
        {
            switch (caseNumber)
            {
                case 1:
                    return null;
                case 2:
                    return new TreeNode(15);
                case 3:
                    return GetCase3();
                case 4:
                    return GetCase4();
                case 5:
                    return GetCase5();
                case 6:
                    return GetCase6();
                case 7:
                    return GetCase7();
                case 8:
                    return GetCase8();
                case 9:
                    return GetCase9();
                case 10:
                    return GetCase10();
                default:
                    throw new NotImplementedException();
            }
        }
        public TreeNode GetCase3()
        {
            return new TreeNode(15) { left = new TreeNode(7) };

        }

        public TreeNode GetCase4()
        {
            return new TreeNode(15) { right = new TreeNode(25) };

        }

        public TreeNode GetCase5()
        {
            return new TreeNode(15)
            {
                left = new TreeNode(7),
                right = new TreeNode(25)
            };

        }

        public TreeNode GetCase6()
        {
            var ret = GetCase3();
            ret.left.left = new TreeNode(5);
            return ret;

        }

        public TreeNode GetCase7()
        {
            var ret = GetCase6();
            ret.left.left.left = new TreeNode(3);
            return ret;

        }

        public TreeNode GetCase8()
        {
            var ret = GetCase7();
            ret.left.left.right = new TreeNode(6);
            return ret;

        }

        public TreeNode GetCase9()
        {
            var ret = GetCase7();
            ret.left.left.left.right = new TreeNode(4);
            return ret;

        }

        public TreeNode GetCase10()
        {
            var ret = GetCase9();
            ret.left.left.right = new TreeNode(6);
            return ret;

        }
    }
}