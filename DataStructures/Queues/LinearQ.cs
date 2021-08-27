using System;

namespace DataStructures.Queues
{
    public class LinearQ<T>
    {
        private readonly T[] ele;
        public int front;
        public int rear;
        private readonly int max;

        public LinearQ(int size)
        {
            ele = new T[size];
            front = 0;
            rear = -1;
            max = size;
        }

        /// <summary>
        /// function to enqueue into the stack
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        /// <summary>
        /// dequeue element
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return default;
            }
            else
            {
                Console.WriteLine("deleted element is: " + ele[front]);
                return ele[front++];
            }
        }

        /// <summary>
        /// gets the elements from both ends front and rear
        /// </summary>
        public void Peek()
        {
            Console.WriteLine("\nPeek function showing element at front and rear of the queue : ");
            Console.WriteLine("\nFront {0} Rear {1} ", ele[front], ele[rear]);
        }

        /// <summary>
        /// checks if the queue contains an element 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="f"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool Contains(T x, int f, int r)
        {
            for (int i = f; i <= r; i++)
            {
                if (x.Equals(ele[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// reverses the queue
        /// </summary>
        public void Reverse()
        {
            int n = (front + rear) / 2;
            for (int i = front, j = rear; i < n && j > n; i++, j--)
            {
                T temp = ele[i];
                ele[i] = ele[j];
                ele[j] = temp;
            }
        }



        /// <summary>
        /// displays the queue.
        /// </summary>
        public void Show()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(ele[i] + "-->");
                }
            }
        }

    }
}
