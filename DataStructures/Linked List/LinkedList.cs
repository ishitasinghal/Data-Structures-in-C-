using DataStructures.Linked_List;
using System;

namespace DataStructures
{
        public class LinkedList<T>
        {
            private Node<T> head = null;
            private Node<T> tail = null;
            private int count = 0;

            /// <summary>
            /// Adding at the front of linked list
            /// </summary>
            /// <param name="data"></param>
            public void AddAtStart(T data)
            {
                Node<T> newNode = new Node<T>();
                if (head == null)
                {
                    tail = newNode;
                }
                newNode.Val = data;
                newNode.Next = head;
                head = newNode;

                count++;
            }

            /// <summary>
            /// Adding at the tail of linked list
            /// </summary>
            /// <param name="data"></param>
            public void AddAtLast(T data)
            {
                Node<T> newNode = new Node<T>();
                newNode.Val = data;
                if (head == null)
                {
                    head = newNode;
                    newNode.Next = null;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Next = null;
                    tail = tail.Next;
                }

                count++;


            }

            /// <summary>
            /// Inserting an element at a given position
            /// </summary>
            /// <param name="pos"></param>
            /// <param name="data"></param>
            public void InsertPos(int pos, T data)
            {
                if (pos > count + 1)
                {
                    Console.WriteLine("position out of range");
                    return;
                }

                else if (pos == 1)
                {
                    AddAtStart(data);
                }

                else if (pos == count + 1)
                {
                    AddAtLast(data);
                }

                else
                {
                    Node<T> newNode = new Node<T>();
                    newNode.Val = data;
                    Node<T> h = head;
                    int i = 1;
                    while (h != null)
                    {
                        if (i == pos - 1)
                        {
                            newNode.Next = h.Next;
                            h.Next = newNode;
                        }
                        h = h.Next;
                        i++;
                    }
                    count++;
                }


            }

            /// <summary>
            /// Removing the first element from the linked list.
            /// </summary>
            public void RemoveFromStart()
            {
                if (count > 0)
                {
                    head = head.Next;
                    count--;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }

            /// <summary>
            /// Deleting an element from a given position
            /// </summary>
            /// <param name="pos"></param>
            public void DelPos(int pos)
            {

                if (count <= 0)
                {
                    Console.WriteLine("No element exist in this linked list.");
                    return;
                }
                if (pos > count + 1)
                {
                    Console.WriteLine("position out of range");

                }

                else if (pos == 1)
                {
                    RemoveFromStart();
                }



                else
                {

                    Node<T> h = head;

                    int i = 2;
                    while (h != null)
                    {
                        if (i == pos)
                        {
                            h.Next = h.Next.Next;
                        }
                        h = h.Next;
                        i++;
                    }
                    count--;
                }


            }

            /// <summary>
            /// Reversing the linked list.
            /// </summary>
            public void Reverse()
            {
                Node<T> prev = null, current = head, next = null;
                while (current != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                }
                head = prev;
            }

            /// <summary>
            /// Finding the centre of the linked list.
            /// </summary>
            public void Center()
            {
                Node<T> slow = head;
                Node<T> fast = head;
                while (fast != null && fast.Next != null)
                {
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }
                Console.WriteLine("\nThe centre element of the list is " + slow.Val);
            }

            /// <summary>
            /// Dsiplaying the linked list.
            /// </summary>
            public void Show()
            {
                Node<T> h = head;
                while (h != null)
                {
                    Console.WriteLine(h.Val+" ");
                    h = h.Next;
                }
            }


            /// <summary>
            /// Getting the size of the linked list.
            /// </summary>
            public void Size()
            {
                Console.WriteLine(count);
            }
        }
    }

