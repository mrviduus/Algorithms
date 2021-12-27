namespace LinkedList;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Linked List test");
        LinkedList<int> instance = new LinkedList<int>();
        instance.Add(12);
        instance.Add(15);
        instance.Add(17);
        instance.Add(19);
        instance.Add(21);
        Display(instance, "List");
        instance.Remove(19);
        Display(instance, "19 was removed");
        System.Console.WriteLine("Copy list in array");
        int [] arr = new int [10];
        instance.CopyTo(arr, 2);
        for(int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine(arr[i]);
        }
         instance.Clear();
         Display(instance, "List is cleared");
        System.Console.ReadKey();
    }
    public static void Display(LinkedList<int> words, string test)
    {
        System.Console.WriteLine(test);
        System.Console.WriteLine();
        foreach(int word in words)
        {
            System.Console.WriteLine(word + " ");
        }
        System.Console.WriteLine();
    }
}

