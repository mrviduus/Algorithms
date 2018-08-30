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

      // ���������, ����� �� ���� ������ ��������� �����:
      // - ���� ����� ������� ����� ���� - ������ ������;
      // - ���� ������� ������� ������ ������� �������� �������, ������, ��� � ������� ���;
      // - ���� ������� ������� ������ ���������� �������� �������, ������, ��� � ������� ���.
      // ���� �� ����� ������ ��������� �����
      if ((arr.Length == 0) || (x < arr[0]) || (x > arr[arr.Length - 1])) return null;

      int first = 0;//������ �������
      int last = arr.Length;//����� �������
      

      while (first < last)//��������� ���� ���� ������ ����� ������ ����������
      {
        int mid = first + (last - first) / 2;//���� � ����� ������� ������� ���������� �����

        if (x <= arr[mid])// ���� x <= �������� �����
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
      //��� ��������� ������ ������ ���� ��������������� ������

      int[] a = { 1, 3, 5, 7, 9, 20, 8 };// ����������������� ������
      //�������� ���������� ���������

      for (int i = 0; i < a.Length; i++)
      {
        for (int j = i+1; j < a.Length; j++)// j = ��������� ������� � �������
        {
          if (a[i] > a[j])// ���� ������ ������� ������ ����������
          {
            int temp = a[i];// ���������� ��������
            a[i] = a[j];//������ ������� ������� �� �������
            a[j] = temp;//�������������� ��������
          }
        }
      }


      Console.WriteLine("���� -1: {0}", BinarrySearch(a, -1));
      Console.WriteLine("����  3: {0}", BinarrySearch(a, 3));
      Console.WriteLine("����  6: {0}", BinarrySearch(a, 6));
      Console.WriteLine("����  9: {0}", BinarrySearch(a, 9));
      Console.WriteLine("���� 20: {0}", BinarrySearch(a, 20));
      Console.ReadLine();

    }
  }
}
