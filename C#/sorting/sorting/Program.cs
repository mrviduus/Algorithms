using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace sorting
{
  public static class QuickSorting
  {
    public static void sorting(double [] arr, long first, long last)
    {
      double p = arr[(last - first) / 2 + first];
      double temp;
      long i = first, j = last;
      while(i <= j)
      {
        while (arr[i] < p && i <= last) ++i;
        while (arr[j] > p && j >= first) --j;
        if (i <= j)
        {
          temp = arr[i];
          arr[i] = arr[j];
          arr[j] = temp;
          ++i; --j;
        }

      }
      if (j > first) sorting(arr, first, j);
      if (i < last) sorting(arr, i, last);
    }

  }

  class Program
  {
   

    static void Main(string[] args)
    {
      double[] arr = new double[10];
     
      // fill in random numbers
      Random rd = new Random();
            
      for (int i = 0; i < arr.Length; ++i)
      {
        arr[i] = rd.Next(1, 11);
      }
      Console.WriteLine("The array before sorting: ");

      foreach (double x in arr)
        Console.Write(x + " ");

      //Sorting
      QuickSorting.sorting(arr, 0, arr.Length - 1);
      
      Console.WriteLine("\n\nThe array after sorting: ");
      foreach(double x in arr)
        Console.Write(x + " ");

      Console.ReadKey();
    }
  }
}
