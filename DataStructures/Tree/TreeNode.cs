using System.Collections.Generic;

namespace DataStructures.Tree
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode child { get; set; }
        public TreeNode siblings { get; set; }

        public TreeNode(int data)
        {
            Value = data;
        }
    }
}
