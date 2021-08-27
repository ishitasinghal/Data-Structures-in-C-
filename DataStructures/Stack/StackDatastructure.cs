using System;
using System.Collections.Generic;
using DataStructures.Stack;

namespace DataStructures
{
	class StackDatastructure
    {
		/// <summary>
		/// taking inputs from user.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public List<int> Input(int length = 5)
		{
			List<int> vs = new List<int>(5);
			while (length > 0)
			{
				vs.Add(int.Parse(Console.ReadLine()));
				length--;
			}
			return vs;
		}
	


		public StackDatastructure()
        {
			LinkStack<int> ls = new LinkStack<int>();
			Console.WriteLine("Enter items to push in stack");
			List<int> stlist = Input();

			foreach(int j in stlist)
            {
				ls.Push(j);
            }
			Console.WriteLine("Items pushed to the stack");
			ls.Show();
			ls.Peek();
			ls.Pop();
			StackNode<int> topp = ls.top;

			Console.WriteLine("Enter element to check in stack");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("\nChecking for item 20 in list : " + ls.Contains(n, topp));
			ls.Size();
			ls.Reverse();
			ls.Show();
			Console.ReadKey();
		}
        
    }
}