static void QuickSort(int[] array)
{
    QuickSortImpl(array, 0, array.Length -1);
}

static void QuickSortImpl(int[] array, int left, int right)
{
    int i = left, j = right;
    int pivot = array[(left + right) >> 1]; // >> 1 == divide on 2
    
    while(i  <= j)
    {
        while(array[i] < pivot)
        {
            i++;
        }

        while(array[j] > pivot)
        {
            j--;
        }

        if(i <= j)
        {
            // Swap
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;

            i ++;
            j --;
        }
    }

    //Recursive calls
    if(left < j)
    {
        QuickSortImpl(array, left, j);
    }
    if(i < right)
    {
        QuickSortImpl(array, i, right);
    }
}




System.Console.WriteLine("Array without sort");

int[] array = {3, 7, 4, 4, 6, 5, 8, 12, 19, 2, 0 };

for(int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}

QuickSort(array);

Console.WriteLine("QuickSort algorithm");

for(int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}