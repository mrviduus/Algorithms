namespace Queue;

class Queue<T>
{
    private class Node
    {
        public T data { get; set; }

        public Node next { get; set; }

        public Node(T data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }

    private Node head;
    private Node tail;

    private int count;

    public Queue()
    {
        head = tail = null;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if(tail == null)
        {
            head = tail = new Node(item, null);
        }
        else
        {
            tail.next = new Node(item, null);
            tail = tail.next;
        }
        count ++;
    }

    public T Dequeue()
    {
        if(head == null)
        {
            return default(T);
        }

        T result = head.data;
        head = head.next;
        return result;
    }

    public T Peek()
    {
        if(head == null)
        {
            return default(T);
        }
        return head.data;
    }

}