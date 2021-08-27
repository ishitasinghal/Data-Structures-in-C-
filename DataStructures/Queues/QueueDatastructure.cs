using DataStructures.Queues;
using System;
using System.Collections.Generic;

namespace DataStructures
{
        class QueueDatastructure
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
        public QueueDatastructure()
        {
            LinearQ<int> lq = new LinearQ<int>(5);
            Console.WriteLine("Enter elements to enqueue");
            List<int> qlist = Input();
            foreach(int j in qlist)
            {
                lq.Enqueue(j);
            }
            

            Console.WriteLine("\nThe items in the queue after enqueuing are : ");
            lq.Show();
            lq.Peek();
            Console.WriteLine("\nThe items in the queue after dequeing(from front) are : ");
            lq.Dequeue();
            lq.Show();

            Console.WriteLine("Enter element to check in queue");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nItem 3 is present in queue : "+lq.Contains(num, lq.front, lq.rear));
            int s = lq.rear + 1;
            Console.WriteLine("\nSize of the queue is : "+ s);
            Console.WriteLine("\nReverse queue");
            lq.Reverse();
            lq.Show();
            Console.ReadKey();
        }
        }
}
