using System;
using System.Collections.Generic;

namespace DataStructures.Linked_List
{
    public class LList
    {

        /// <summary>
        /// method to take inputs from the user.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public List<int> Input(int length =5)
        {
            List<int> vs = new List<int>(5);
            while (length > 0)
            {
                vs.Add(int.Parse(Console.ReadLine()));
                length--;
            }
            return vs;   
        }
        
        public LList()
        {

            LinkedList<int> lnklist = new LinkedList<int>();

            Console.WriteLine("Enter the contents of the list");
            List<int> inputList = Input();
            Console.WriteLine("\nInitially linked list");
            Console.WriteLine("\nAdding at the end of linked list");
            foreach (int j in inputList)
            {
                lnklist.AddAtLast(j);
            }
            lnklist.Show();
            Console.WriteLine();

            lnklist.Show();
            Console.WriteLine();

            Console.WriteLine("\nAdding at the front of linked list");
            lnklist.AddAtStart(0);
            lnklist.Show();
            Console.WriteLine();


            Console.WriteLine("\nRemoving from the front of linked list");
            lnklist.RemoveFromStart();
            lnklist.Show();
            Console.WriteLine();


            Console.WriteLine("\nAdding data 43 at position 3");
            lnklist.InsertPos(3, 43);
            lnklist.Show();
            Console.WriteLine();

            Console.WriteLine("\nRemoving data at position 3");
            lnklist.DelPos(3);
            lnklist.Show();
            Console.WriteLine();

            lnklist.Center();

            Console.WriteLine("\nReversed linked list");
            lnklist.Reverse();
            lnklist.Show();
            Console.WriteLine();

            Console.WriteLine("\nSize of the linked list");
            lnklist.Size();



            Console.ReadKey();



        }
    }
}
