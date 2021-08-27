using System;

namespace DataStructures.Hash_Table
{
    public class HashTable<T>
    {
        private readonly HashNode<T>[] bucket; //array to store data on lists in array
        /// <summary>
        /// constructor to initialize the bucket array
        /// </summary>
        /// <param name="size"></param>
        public HashTable(int size)
        {
            bucket = new HashNode<T>[size];
        }

        
        /// <summary>
        /// validate key function
        /// </summary>
        /// <param name="key"></param>
        protected void ValidateKey(string key)
        {
            //a key can't be empty
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// this function gets the node inside the hash table
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get(string key)
        {
            ValidateKey(key);
            var (_, node) = GetNodeByKey(key);
            //if key is not found
            if (node == null)
                throw new ArgumentOutOfRangeException(nameof(key), $"The key '{key}' is not found!");
            return node.Val;
        }



        /// <summary>
        /// function to add key value pairs int the hash table.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        public void Add(string key, T item) //providing key value pair to the function
        {
            //the key requires to be validated.
            ValidateKey(key);
            var valueNode = new HashNode<T> { Key = key, Val = item, Next = null };
            int position = GetBucketByKey(key);
            HashNode<T> listNode = bucket[position];
            if (null == listNode) //if no node is there, we add it to the bucket
            {
                bucket[position] = valueNode;
            }
            else
            {
                while (null != listNode.Next)
                {
                    listNode = listNode.Next;
                }
                listNode.Next = valueNode; //setting the pointer to the newly created node.
            }

        }

        /// <summary>
        /// it finds the node if it exists with the help of key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public (HashNode<T> prev, HashNode<T> current) GetNodeByKey(string key)
        {
            int position = GetBucketByKey(key);
            HashNode<T> listNode = bucket[position];
            HashNode<T> prev = null;

            while (null != listNode)
            {
                if (listNode.Key == key)
                    return (prev, listNode);
                prev = listNode;
                listNode = listNode.Next;
            }
            return (null, null);
        }



        /// <summary>
        /// removes a node from the hash table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            ValidateKey(key);
            int position = GetBucketByKey(key);

            var (previous, current) = GetNodeByKey(key);

            if (null == current)
                return false;
            if (null == previous)
            {
                bucket[position] = null;
                return true;
            }
            previous.Next = current.Next;
            return true;

        }

        /// <summary>
        /// checks if the hash table already contains the key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(string key)
        {
            ValidateKey(key);
            var (_, node) = GetNodeByKey(key);
            return null != node;
        }

        public int GetBucketByKey(string key)
        {
            return key[0] % bucket.Length;
        }



    }
}










/*
    Time complexity : O(1) [for all operations]
    Space complexity : O(N)

    where N is the number of elements in the HashMap
*/

//import java.util.ArrayList;

//class Entry
//{
//    String key;
//    int value;
//    Entry next;

//    public Entry(String key, int value)
//    {
//        this.key = key;
//        this.value = value;
//    }

//    public Entry()
//    {
//        this.key = new String();
//        this.value = 0;
//    }
//}

//public class MyHashMap
//{
//    private ArrayList<Entry> buckets;
//    private int size;

//    public MyHashMap()
//    {
//        this.buckets = new ArrayList<>();
//        this.size = 0;

//        // Initialise bucket list with 3 elements.
//        for (int i = 0; i < 3; i++)
//        {
//            this.buckets.add(null);
//        }
//    }

//    // This function find the bucket index for the string key
//    private int getBucketIndex(String key)
//    {
//        int hashcode = key.hashCode();
//        int bucketIndex = ((hashcode % this.buckets.size()) + this.buckets.size()) % this.buckets.size();
//        return bucketIndex;
//    }

//    // This function doubles the size of HashMap
//    private void rehash()
//    {
//        ArrayList<Entry> temp = this.buckets;
//        this.buckets = new ArrayList<>();

//        // Increasing the size of buckets
//        for (int i = 0; i < temp.size() * 2; i++)
//        {
//            this.buckets.add(null);
//        }

//        this.size = 0;

//        // Insert all key from temp into buckets
//        for (int i = 0; i < temp.size(); i++)
//        {
//            Entry head = temp.get(i);
//            Entry current = head;

//            while (current != null)
//            {
//                this.insert(current.key, current.value);
//                current = current.next;
//            }
//        }
//    }

//    public int get(String key)
//    {
//        // Finding the bucket index for the key
//        int bucketIndex = this.getBucketIndex(key);

//        Entry head = this.buckets.get(bucketIndex);
//        Entry temp = head;

//        // Traverse through the buckets[bucketIndex]
//        while (temp != null)
//        {
//            if (temp.key.equals(key))
//            {
//                // Returns the integer value stored against the given key
//                return temp.value;
//            }

//            temp = temp.next;
//        }

//        return -1;
//    }

//    public void insert(String key, int value)
//    {
//        // Finding the bucket index for the key
//        int bucketIndex = this.getBucketIndex(key);

//        Entry head = this.buckets.get(bucketIndex);
//        Entry newNode = new Entry();

//        newNode.key = key;
//        newNode.value = value;

//        if (head == null)
//        {
//            this.buckets.set(bucketIndex, newNode);
//            this.size += 1;
//        }
//        else
//        {
//            Entry temp = head;
//            Entry prev = null;

//            // Check if key is already present in HashMap by traversing through the buckets[bucketIndex]
//            while (temp != null)
//            {
//                if (temp.key.equals(key))
//                {
//                    temp.value = value;
//                    return;
//                }

//                prev = temp;
//                temp = temp.next;
//            }

//            prev.next = newNode;
//            this.size += 1;
//        }

//        // Find the load factor of the HashMap
//        double loadFactor = (size * 1.0) / buckets.size();

//        // Check if loadFactor is greater than 0.75
//        if (loadFactor >= 0.75)
//        {
//            this.rehash();
//        }
//    }

//    public void remove(String key)
//    {
//        // Finding the bucket index for the key
//        int bucketIndex = this.getBucketIndex(key);
//        Entry head = this.buckets.get(bucketIndex);

//        if (head == null)
//        {
//            return;
//        }

//        Entry temp = head;
//        Entry prev = null;

//        // Traverse through the buckets[bucketIndex]
//        while (temp != null)
//        {
//            if (temp.key.equals(key))
//            {
//                // Delete the key from the HashMap and decrement size by 1
//                if (prev == null)
//                {
//                    this.buckets.set(bucketIndex, head.next);
//                }
//                else
//                {
//                    prev.next = temp.next;
//                }

//                this.size -= 1;

//                return;
//            }

//            prev = temp;
//            temp = temp.next;
//        }
//    }

//    public boolean search(String key)
//    {
//        // Check if key is not present in the HashMap
//        if (this.get(key) == -1)
//        {
//            return false;
//        }

//        return true;
//    }

//    public int getSize()
//    {
//        // Return the size of HashMap
//        return this.size;
//    }

//    public boolean isEmpty()
//    {
//        // Check if the size of HashMap is equal to 0
//        return this.getSize() == 0;
//    }
//}