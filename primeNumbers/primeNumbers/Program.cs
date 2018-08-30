using System;


namespace primeNumbers
{
  class Program
  {
    
    static void Main(string[] args)
    {
      //Простые числа
      bool isPrime(int number)
      {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
          if (number % i == 0) return false;
        return true;
      }
      Console.WriteLine("Enter number: ");
      int input = int.Parse(Console.ReadLine());
      if(isPrime(input))
        Console.WriteLine("Number {0} is prime", input.ToString());
      else
        Console.WriteLine("Number {0} is unprime", input.ToString());
      Console.ReadKey();
    }
  }
}
