using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
  class Program
  {

    //Fibonaci
    static int FibRec(int p1, int p2, int n)
    {
      return n == 0 ? p1 : FibRec(p2, p1 + p2, n - 1);
    }
    static int Fib(int n) { return FibRec(0, 1, n); }



    //factorial
    public static int Factorial(int x)
    {
      //Останавливаем рекурсию
      if (x == 0)
        return 1;
      else
        return x * Factorial(x - 1);
    }
    //Factorial

    //bashni hanoja
    static void hanoi(int x, char from, char to, char help)
    {
      if (x > 0)
      {
        hanoi(x - 1, from, help, to);
        move(x, from, to);
        hanoi(x - 1, help, to, from);
      }

    }

    static void move(int x, char from, char to)
    {
      Console.WriteLine("  берем диск " + x + " из " + from + " в " + to);
    }


    //bashni hanoja



    static void Main(string[] args)
    {
      int x;
      char from = 'A', to = 'B', help = 'C';

      do
      {
        try
        {
          Console.Write("Введите количество дисков: ");
          x = Int32.Parse(Console.ReadLine());
        }
        catch (FormatException e)
        {
          x = -10;
        }
      } while (x == -10 || x > 10);
      Console.WriteLine("\n  откуда = A, куда = B, вспомогательная колона = C\n");
      hanoi(x, from, to, help);
      //basni hanoja


      Console.WriteLine("Enter number for factorial: ");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("Factorial is: {0}", Factorial(n));
      Console.ReadKey();
    }
  }
}
