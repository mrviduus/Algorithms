using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
  class Program
  {

    private static int? BinarrySearch(int[] arr, int x)
    {

      // Check to see if the smylie ever performs a search:
      // - if the length of the array is zero, there is nothing to look for;
      // - if the required element is smaller than the first element of the array, then it is not in the array;
      // - if the required element is greater than the last element of the array, then it is not in the array.
      // is there any sense in doing a search
      if ((arr.Length == 0) || (x < arr[0]) || (x > arr[arr.Length - 1])) return null;

      int first = 0;//Start of Array
      int last = arr.Length;//End of Array


      while (first < last)//run the loop if the first number is less than the last
      {
        int mid = first + (last - first) / 2;//we look in what side of the array there is a number

        if (x <= arr[mid])
        {
          last = mid;
        }
        else
        {
          first = mid + 1;
        }

      }
      if (arr[last] == x)
      {
        return last;
      }
      else return null;
    }
    static void Main(string[] args)
    {
      //For a binary search, there must be a sorted array

      int[] a = { 1, 3, 5, 7, 9, 20, 8 };// unsorted array
      //We pass the sorting by a bubble

      for (int i = 0; i < a.Length; i++)
      {
        for (int j = i + 1; j < a.Length; j++)//  j = the next element in the array
        {
          if (a[i] > a[j])// if the first element is greater than the next
          {
            int temp = a[i];// write the value
            a[i] = a[j];//change the larger element to a smaller one
            a[j] = temp;//overwrite the value
          }
        }
      }


      Console.WriteLine("Searching -1: {0}", BinarrySearch(a, -1));
      Console.WriteLine("Searching  3: {0}", BinarrySearch(a, 3));
      Console.WriteLine("Searching  6: {0}", BinarrySearch(a, 6));
      Console.WriteLine("Searching  9: {0}", BinarrySearch(a, 9));
      Console.WriteLine("Searching 20: {0}", BinarrySearch(a, 20));
      Console.ReadLine();

    }
  }
}