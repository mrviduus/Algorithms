using System;

namespace bS
{
  class programm
  {
    public static int? binarrySearch(int[] arr, int x)
    {

      if ((arr.Length == 0) || (x < arr[0]) || (x > arr[arr.Length - 1])) return null;

      int first = 0;
      int last = arr.Length;

      while (first < last)
      {
        int mid = first + (last - first) / 2;

        if (x <= arr[mid])
          last = mid;
        else
          first = mid + 1;// 

      }
      if (x == arr[last])
        return last;
      else
        return null;
    }


    static void Main()
    {

      int[] a = { 1, 23, 4, 54, 6, 778, 43 };

      for (int i = 0; i < a.Length; i++)
        for (int j = i + 1; j < a.Length; j++)
        {
          int temp = a[i];
          a[i] = a[j];
          a[j] = temp;
        }

      Console.WriteLine("»щем 778 {0}", binarrySearch(a, 778));
      Console.WriteLine("»щем 5 {0}", binarrySearch(a, 5));
      Console.WriteLine("»щем -1 {0}", binarrySearch(a, -1));
      Console.WriteLine("»щем 54 {0}", binarrySearch(a, 54));
      Console.WriteLine("»щем 6 {0}", binarrySearch(a, 6));



      Console.ReadKey();
    }
  }
}