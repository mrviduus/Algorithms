namespace HashTable;

public class HashTableItem<T, V>
{
    public T Key {get; private set;}
    
    public V Value { get; private set; }

    public HashTableItem(T key, V val)
    {
        Key = key;
        Value = val;
    }
}