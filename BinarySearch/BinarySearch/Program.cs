using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
  class Program
  {

    private static int? BinarrySearch(int [] arr, int x)
    {

      // ѕроверить, имеет ли смыл вообще выполн€ть поиск:
      // - если длина массива равна нулю - искать нечего;
      // - если искомый элемент меньше первого элемента массива, значит, его в массиве нет;
      // - если искомый элемент больше последнего элемента массива, значит, его в массиве нет.
      // есть ли смысл вообще выполн€ть поиск
      if ((arr.Length == 0) || (x < arr[0]) || (x > arr[arr.Length - 1])) return null;

      int first = 0;//Ќачало массива
      int last = arr.Length;// онец массива
      

      while (first < last)//запускаем цикл если первое число меньше последнего
      {
        int mid = first + (last - first) / 2;//ищем в какой стороне массива находитьс€ число

        if (x <= arr[mid])// ≈сли x <= среднему чилсу
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
      //ƒл€ бинарного поиска должен быть отсортированный массив

      int[] a = { 1, 3, 5, 7, 9, 20, 8 };// неотсортированный массив
      //ѕроходим сортировку пузырьком

      for (int i = 0; i < a.Length; i++)
      {
        for (int j = i+1; j < a.Length; j++)// j = следующий элемент в массиве
        {
          if (a[i] > a[j])// если первый елемент больше следующего
          {
            int temp = a[i];// записываем значение
            a[i] = a[j];//мен€ем больший елемент на меньший
            a[j] = temp;//перезаписываем значение
          }
        }
      }


      Console.WriteLine("»щем -1: {0}", BinarrySearch(a, -1));
      Console.WriteLine("»щем  3: {0}", BinarrySearch(a, 3));
      Console.WriteLine("»щем  6: {0}", BinarrySearch(a, 6));
      Console.WriteLine("»щем  9: {0}", BinarrySearch(a, 9));
      Console.WriteLine("»щем 20: {0}", BinarrySearch(a, 20));
      Console.ReadLine();

    }
  }
}
