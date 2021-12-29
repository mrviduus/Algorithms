namespace DynamicArray;

internal class DynamicArray<T>
{
    private T[] data;

    private int count;

    public DynamicArray(int size)
    {
        data = new T[size];
        count = 0;
    }

    private void resize()
    {
        int capacity = data.Length == 0 ? 4 : data.Length * 2;
        T[] newArr = new T[capacity];

        data.CopyTo(newArr, 0);

        data = newArr;
    }

    public bool IsFull()
    {
        return count == data.Length;
    }

    public void Add(T item)
    {
        if(this.IsFull())
        {
            this.resize();
        }

        data[count++] = item;
    }

    public void Insert(T item, int index)
    {
        if(index > count)
        {
            return;
        }

        if(this.IsFull())
        {
            this.resize();
        }

        Array.Copy(data, index, data, index + 1, count - index);
        data[index] = item;

        count++;
    }

    public void RemoveAt(int index)
    {
        int shiftStart = index + 1;

        if(shiftStart < count)// Если удаляется не последний элемент массива
        {
            // Сдвиг массива на один элемент влево
            Array.Copy(data, shiftStart, data, index, count - shiftStart);
        }

        count --;
        data[count] = default(T);
    }


    public bool Remove(T item)
    {
        for(int i = 0; i < count; i++)
        {
            if(data[i].Equals(item))
            {
                RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public int IndexOf(T item)
    {
        for(int i = 0; i < count; i++)
        {
            if(data[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Contains(T item)
    {
        return IndexOf(item) != -1;

    }



}