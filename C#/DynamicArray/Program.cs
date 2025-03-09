namespace DynamicArray;

class Program
{
    static void Main(string[] args)
    {
        DynamicArray<int> arr = new DynamicArray<int>(3);

        arr.Add(1);
        arr.Add(2);
        arr.Add(3);
        arr.Add(4);
        arr.Insert(5, 5);

        //
        DynamicArray<int> arr2 = new DynamicArray<int>(10);
        for(int i = 1; i < 11; i++) arr2.Add(i);

        System.Console.WriteLine("Contains '5'   :  " + arr2.Contains(5));
        System.Console.WriteLine("Contains '200'   :  " + arr2.Contains(200));
        System.Console.WriteLine("IndexOf '7'   :  " + arr2.IndexOf(7));

        arr2.RemoveAt(2);
        arr2.RemoveAt(0);
        arr2.Remove(5);

        System.Console.WriteLine("Show removed elements");

        System.Console.WriteLine("Contains '5'   :  " + arr2.Contains(5));

        System.Console.ReadKey();

    }    
}

