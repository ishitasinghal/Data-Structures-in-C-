using DataStructures.Priority_Queue;
using System;

namespace DataStructures
{
    
    class PriorityQ
    {
        public QueueNode node = new QueueNode();
        
        /// <summary>
        /// initializing the new queue node 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="prty"></param>
        /// <returns></returns>
        public QueueNode NewNode(int d, int prty)
        {
            QueueNode temp = new QueueNode
            {
                data = d,
                priority = prty,
                next = null
            };

            return temp;
        }

        /// <summary>
        /// getting the head element of the priority queue.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int Peek(QueueNode head)
        {
            return (head).data;
        }

        /// <summary>
        /// Enqueus the element
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public QueueNode Enqueue(QueueNode head)
        {
            head = head.next;
            return head;
        }

        /// <summary>
        /// Dequeues the element with highest priority
        /// </summary>
        /// <param name="head"></param>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public QueueNode Dequeue(QueueNode head, int d, int p)
        {
            QueueNode start = (head);
            QueueNode temp = NewNode(d, p);
            if ((head).priority > p)
            {
                temp.next = head;
                (head) = temp;
            }
            else
            {
                while (start.next != null && start.next.priority < p)
                {
                    start = start.next;
                }
                temp.next = start.next;
                start.next = temp;
            }

            return head;
        }
        /// <summary>
        /// checks if the queue is empty
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public int IsEmpty(QueueNode head)
        {
            return ((head) == null) ? 1 : 0;
        }

        /// <summary>
        /// Checks for an element in queue
        /// </summary>
        /// <param name="x"></param>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool Contains(int x, QueueNode head)
        {
            while (head != null)
            {
                if (head.data == x)
                {

                    return true;
                }
                head = head.next;
            }
            return false;
        }

        /// <summary>
        /// displays the queue
        /// </summary>
        /// <param name="head"></param>
        public void Show(QueueNode head)
        {
            QueueNode start = (head);
            Console.WriteLine("Data -->  Priority");
            while (start.next != null)
            {
                Console.WriteLine(start.data + " --> " + start.priority);
                start = start.next;
            }
            //Console.WriteLine(start.data + start.priority);
        }

        /// <summary>
        /// gets the size of queue.
        /// </summary>
        /// <param name="head"></param>
        public void Size(QueueNode head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            count--;
            Console.WriteLine("size of queue " + count);

        }

        /// <summary>
        /// reverses the queue
        /// </summary>
        public void Reverse(QueueNode head)
        {
            Console.WriteLine("Data -->  Priority");
            QueueNode prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            while (head.next != null)
            {
                Console.WriteLine(head.data + " --> " + head.priority);
                head = head.next;
            }

        }


        public PriorityQ()
        {

            Console.WriteLine("The enqueue items in the queue are : ");

            QueueNode pq = NewNode(4, 1);
            pq = Dequeue(pq, 5, 2);
            pq = Dequeue(pq, 6, 3);
            pq = Dequeue(pq, 7, 0);
            pq = Dequeue(pq, 29, 3);
            Show(pq);


            Console.WriteLine("After dequeing");
            pq = Enqueue(pq);

            Show(pq);
            Console.WriteLine("Enter an element to search in queue");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine(Contains(e, pq));

            Size(pq);

            Reverse(pq);

            Console.ReadKey();

        }

    }



}


       
    

