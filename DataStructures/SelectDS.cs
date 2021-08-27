using DataStructures.Linked_List;
using System;

namespace DataStructures
{
    class SelectDS
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("WELCOME TO DATA STRUCTURES");
            Console.WriteLine("1 ----> LINKED LIST DATA STRUCTURE");
            Console.WriteLine("2---- > STACK DATA STRUCTURE");
            Console.WriteLine("3---- > QUEUE DATA STRUCTURE");
            Console.WriteLine("4 ----> PRIORITY QUEUE DATA STRUCTURE");
            Console.WriteLine("5 ----> N-CHILD TREE DATA STRUCTURE");
            Console.WriteLine("6 ----> HASH TABLE");

            string c = Console.ReadLine();
            switch (c)
            {
                case "1":
                    Console.WriteLine("RUNNING LINKED LIST DATA STRUCTURE");
                    _ = new LList();
                    break;

                case "2":
                    Console.WriteLine("RUNNING STACK DATA STRUCTURE");
                    _ = new StackDatastructure();
                    break;

                case "3":
                    Console.WriteLine("RUNNING QUEUE DATA STRUCTURE");
                    _ = new QueueDatastructure();
                    break;

                case "4":
                    Console.WriteLine("RUNNING PRIORITY QUEUE DATA STRUCTURE");
                    _ = new PriorityQ();
                    break;

                case "5":
                    Console.WriteLine("RUNNING N-ARY TREE DATA STRUCTURE");
                    _ = new NTree();
                    break;

                case "6":
                    Console.WriteLine("RUNNING HASH TABLE DATA STRUCTURE");
                    _ = new HashtableDS();
                    break;

                default:
                    Console.WriteLine("WRONG CHOICE");
                    break;
            }
        }
    }
}
