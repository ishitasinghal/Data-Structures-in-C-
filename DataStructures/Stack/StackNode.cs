namespace DataStructures.Stack
{
    //node for the stack
    public class StackNode<T>
    {
        public T Val;
        public StackNode<T> Next;

        public StackNode(T data)
        {
            this.Val = data;
        }
    }
}
