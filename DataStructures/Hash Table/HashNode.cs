namespace DataStructures.Hash_Table
{
    
    /// <summary>
    /// Node class is important as chaining is require to chain the linked list to avoid collision.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HashNode<T>
    {
        public T Val { get; set; } //object value or data
        public string Key { get; set; } //key in hash table
        public HashNode<T> Next { get; set; }//pointer to the next node.

    }
}
