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

    static void Main(string[] args)
    {
      Console.WriteLine("Enter number for factorial: ");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("Factorial is: {0}", Factorial(n));
      Console.ReadKey();
    }
  }
}
