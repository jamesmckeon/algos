using System.Diagnostics;

namespace Algos.BinarySearchTree
{
    [DebuggerDisplay("{val} : left={displayLeft()}, right = {displayRight()}")]
    public class TreeNode
    {
        public string displayLeft()
        {
            return left == null ? "null" : left.val.ToString();
        }

        public string displayRight()
        {
            return right == null ? "null" : right.val.ToString();
        }

        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public int val { get; set; }

        public TreeNode() { }
        public TreeNode(int val)
        {

            this.val = val;
        }
    }

}
