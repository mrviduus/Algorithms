namespace LinkedList;

using LinkedList.LinkedListNode;

public class LinkedList<T> : System.Collections.Generic.IEnumerable<T>
{
    public LinkedListNode<T> head;
    public LinkedListNode<T> tail;

    public int Count { get; private set; }

    // 1) Создание нового узла
    // 2) Нахождение последнего узла
    // 3) Создание указателя с предыдущего узла на новый
    public void Add (T value)
    {
        
        LinkedListNode<T> node = new LinkedListNode<T>(value);

        if(head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.Next = node;
            tail = node;
        }

        Count ++;
    }

    public bool Remove(T item)
    {
        LinkedListNode<T> previous = null;
        LinkedListNode<T> current = head;

        while(current != null)
        {
            if(current.Value.Equals(item)) // Определяет, равен ли заданный объект текущему объекту.
            {
                // Смена указателя Next из предыдузего на следующий
                if(previous != null)
                {
                    previous.Next = current.Next;

                    // Определяем конец списка

                    if(current.Next == null)
                    {
                        tail = previous;
                    }
                }
                else
                {
                    // Удаление первого элемента списка
                    head = head.Next;

                    // Если список был пуст и был удален единственный элемент
                    if(head == null)
                    {
                        tail = null;
                    }
                }

                Count --;               
                return true;

            }

            previous = current;
            current = current.Next;
        }
        return false;
    }


    public bool Contains(T item)
    {
        LinkedListNode<T> current = head;

        while(current != null)
        {
            if(current.Value.Equals(item))
            {
                return true;
            }

            current = current.Next;
        }       
        return false;
    }


    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        LinkedListNode<T> current = head;

        while(current != null)
        {
            array[arrayIndex++] = current.Value;
            current = current.Next;
        }
    }


    public System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
        LinkedListNode<T> current = head;

        while(current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return ((System.Collections.IEnumerable)this).GetEnumerator();
    }
    
}
