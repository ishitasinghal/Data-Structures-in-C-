using DataStructures.Hash_Table;
using System;
namespace DataStructures
{
    class HashtableDS
    {
        public HashtableDS()
        {
            var h = new HashTable<int>(4);
            //to check which bucket will hold which key.
            Console.WriteLine("Bucket "+h.GetBucketByKey("One")+ "contains key One");
            Console.WriteLine("Bucket " + h.GetBucketByKey("Two") + "contains key Two");
            Console.WriteLine("Bucket " + h.GetBucketByKey("Four") + "contains key Four");
            Console.WriteLine("Bucket " + h.GetBucketByKey("Three") + "contains key Three");
            
            //here key One has value 1, similarly others.
            h.Add("One", 1);
            h.Add("Two", 2);
            h.Add("Three", 3);

            Console.WriteLine("Value at Bucket One "+h.Get("One"));
            Console.WriteLine("Value at Bucket Two " + h.Get("Two"));
            Console.WriteLine("Value at Bucket Three " + h.Get("Three"));
            //Console.WriteLine("Value at Bucket Four " + h.Get("Four"));


            try
            {
                Console.WriteLine(h.Get("Five"));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(h.Remove("Three"));//outputs true as it exists
            Console.WriteLine(h.Remove("Three"));//outputs false as it has already been removed.
            Console.WriteLine(h.Remove("Two"));
            Console.WriteLine(h.Remove("Two"));

            Console.ReadKey();
        }
    }
}
