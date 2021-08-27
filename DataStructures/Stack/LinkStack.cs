using System;

namespace DataStructures.Stack
{
    public class LinkStack<T>
	{
		public StackNode<T> top;

		/// <summary>
		/// pushing data into the stack
		/// </summary>
		/// <param name="data"></param>
		public void Push(T data)
		{
			StackNode<T> newNode = new StackNode<T>(data);
			if (top == null)
			{
				newNode.Next = null;
			}
			else
			{
				newNode.Next = top;
			}
			top = newNode;
		}

		/// <summary>
		/// pops the top value
		/// </summary>
		public void Pop()
		{
			if (top == null)
			{
				Console.WriteLine("Stack Underflow. Deletion not possible");
				return;
			}

			Console.WriteLine("Item popped is {0}", top.Val);
			top = top.Next;
		}

		/// <summary>
		/// get the top element
		/// </summary>
		public void Peek()
		{
			if (top == null)
			{
				Console.WriteLine("Stack Underflow.");
				return;
			}

			Console.WriteLine("\n{0} is on the top of Stack", this.top.Val);
		}

        /// <summary>
		/// Checks whether the stack contains an element or not.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="newTop"></param>
		/// <returns></returns>
		public bool Contains(T x, StackNode<T> newTop)
        {
            if (x.Equals(newTop.Val))
                return true;
			if (newTop == null)
				return false;
			else
				newTop = newTop.Next;
				return Contains(x, newTop);

        }

		/// <summary>
		/// retuen the size of the stack.
		/// </summary>
		public void Size()
		{
			int c = 0;
			StackNode<T> temp = top;
			while (temp != null)
			{
				temp = temp.Next;
				c++;
			}
			Console.WriteLine("Size of the stack is : " + c);

		}

		/// <summary>
		/// reverses the stack
		/// </summary>
		public void Reverse()
		{
			StackNode<T> prev = null, current = top, next = null;
			while (current != null)
			{
				next = current.Next;
				current.Next = prev;
				prev = current;
				current = next;

			}
			top = prev;


		}

		/// <summary>
		/// displays the stack.
		/// </summary>
		public void Show()
		{
			if (top == null)
			{
				Console.Write("\nStack Underflow");
				return;
			}
			else
			{
				StackNode<T> temp = top;
				while (temp != null)
				{
					Console.Write("{0}->", temp.Val);
					temp = temp.Next;
				}
			}
		}



	}
}
