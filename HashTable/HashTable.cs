namespace HashTable;

public class HashTable<TKey, TValue>
{
    private LinkedList<HashTableItem<TKey, TValue>>[] array;
    private int capacity;
    private int size;

    private const double LOAD_FACTOR = 0.75;

    public HashTable(int size)
    {
        capacity = size;
        array = new LinkedList<HashTableItem<TKey, TValue>>[capacity];
    }

    private int hash (TKey key)
    {
        return Math.Abs(key.GetHashCode()) % capacity;
    }

    private double getLoadFactor()
    {
        return size / capacity;
    }

    private void resize()
    {
        capacity = capacity * 2;
        var oldArr = array;
        size = 0;
        array = new LinkedList<HashTableItem<TKey, TValue>>[capacity];

        foreach(var item in oldArr)
        {
            if(item is not null)
            {
                foreach(var pair in item)
                {
                    if(pair is not null)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }
    }

    public void Add(TKey key, TValue val)
    {
        if(getLoadFactor() >= LOAD_FACTOR)
        {
            this.resize();
        }

        int index = hash(key);

        if(array[index] == null)
        {
            array[index] = new LinkedList<HashTableItem<TKey, TValue>>();
        }

        var hashTableItem = new HashTableItem<TKey,TValue>(key, val);

        var listNode = new LinkedListNode<HashTableItem<TKey, TValue>>(hashTableItem);

        array[index].AddFirst(listNode);

        size ++;

    }

    public bool Remove(TKey key)
    {
        int index = hash(key);

        if(array[index] == null)
        {
            return false;
        }

        foreach (var item in array[index])
        {
            if(item.Key.Equals(key))
            {
                array[index].Remove(item);
                break;
            }
        }

        return true;
    }

    public TValue GetValue(TKey key)
    {
        int index = hash(key);

        if(array[index] is null)
        {
            return default(TValue);
        }

        foreach(var item in array[index])
        {
            if(item.Key.Equals(key))
            {
                return item.Value;
            }
        }

        return default(TValue);
    }

    public void Clear()
    {
        size = 0;
        array = new LinkedList<HashTableItem<TKey, TValue>>[capacity];
    }
}