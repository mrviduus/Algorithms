namespace LinkedList.LinkedListNode;
public class LinkedListNode<T>
{
    //Create new node

    public LinkedListNode(T value)
    {
        Value = value;
    }

    // Value
    public T Value { get; internal set; }

    // Next ref 

    public LinkedListNode<T> Next{get; set;}
}
