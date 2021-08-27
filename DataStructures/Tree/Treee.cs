using System;
using System.Collections.Generic;

namespace DataStructures.Tree
{
    public class Treee
    {
        TreeNode Root;

        /// <summary>
        /// this function creates the tree
        /// </summary>
        /// <param name="data"></param>
        public void CreateNarray(int[] data)
        {
            //if the node already exists, then attach to that child.
            TreeNode temp = null;
            if (Root != null)
                temp = Search(Root, data[0]);

            //if no similar node exists
            if (temp == null)
            {
                temp = new TreeNode(data[0]);

            }

            //make parent node
            if (this.Root == null)
                Root = temp;
            TreeNode parent = temp;

            for (int j = 0; j < data[1]; j++)
            {
                // for first child
                if (j == 0)
                {
                    parent.child = new TreeNode(data[j + 2]);
                    parent = parent.child;
                }
                //for all other childs
                else
                {
                    parent.siblings = new TreeNode(data[j + 2]);
                    parent = parent.siblings;
                }
            }
        }

        /// <summary>
        /// this function looks for the nodes that are already present.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public TreeNode Search(TreeNode root, int data)
        {
            if (root == null)
                return null;

            else if (data == root.Value)
                return root;

            TreeNode t = Search(root.child, data);
            if (t == null)
                t = Search(root.siblings, data);

            return t;
        }

        /// <summary>
        /// displays the tree
        /// </summary>
        /// <param name="p"></param>
        public void Show(TreeNode p)
        {
            if (p == null)
                return;
            Console.Write(p.Value+"-->");
            Show(p.child);
            Show(p.siblings);

        }

        /// <summary>
        /// displays the BFS traversal of the tree.
        /// </summary>
        /// <param name="root"></param>
        public void BFSTraverse(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode current = q.Dequeue();
                if (current == null)
                    continue;
                q.Enqueue(current.child);
                q.Enqueue(current.siblings);

                Console.Write(current.Value+"-->");
            }
        }

        /// <summary>
        /// DFS traversal of the tree
        /// </summary>
        /// <param name="root"></param>
        public void DFSTraverse(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            while (s.Count > 0)
            {
                TreeNode n = s.Pop();
                Console.Write(n.Value+"-->");
                if (n.child != null)
                    s.Push(n.child);
                if (n.siblings != null)
                    s.Push(n.siblings);
            }
        }


            public void Print()
        {
            Console.WriteLine("\nInitial view of tree");
            Show(Root);
            Console.WriteLine("\nBFS Traveral of tree");
            BFSTraverse(Root);
            Console.WriteLine("\nDFS Traveral of tree");
            DFSTraverse(Root);
        }




    }
}
