using DataStructures.Tree;
using System;

namespace DataStructures
{
    class NTree
    {
        public NTree()
        {
            //implementing 1-level tree
            Treee treee = new Treee();

            /*1st element in each row is node Value,
            2nd - no of child, ,>=3rd....=>value of child*/
            int[][] data = { 
                new int[] { 1, 3, 2, 3, 4 }, 
                new int[] { 2, 3, 1, 6, 50 }, 
                new int[] { 3, 3, 8, 9, 10 }, 
                new int[] { 4, 3, 0, 0, 0 } 
            };

            for (int i = 0; i < data.GetLength(0); i++) //GetLength to get the first element
            {
                treee.CreateNarray(data[i]);
            }

            treee.Print();
            //treee.BFSTraverse(Root);
            Console.ReadLine();
        }
    }




}
