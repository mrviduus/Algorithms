using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wide_width_search
{
  class Program
  {



    static void Main(string[] args)
    {
      Random rand = new Random();
      Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
      string exit = "";
      int u;
      int v;
      do
      {
        Console.WriteLine("Задать размер массива самостоятельно? ");
        if (Console.ReadLine() == "да")
        {
          Console.WriteLine("Введите размер:");
          u = Convert.ToInt32(Console.ReadLine()) - 1;
          if (u < 3)
          {
            Console.WriteLine("Вы ввели некорректный размер массива. Программа автоматически заменила размер.");
            u = rand.Next(3, 5);
          }
        }
        else
          u = rand.Next(3, 5);
        bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
        int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

        for (int i = 0; i < u + 1; i++)
        {
          g[i] = new int[u + 1];
          Console.Write("\n({0}) вершина -->[", i + 1);
          for (int j = 0; j < u + 1; j++)
          {
            g[i][j] = rand.Next(0, 2);
          }
          g[i][i] = 0;
          foreach (var item in g[i])
          {
            Console.Write(" {0}", item);
          }
          Console.Write("]\n");

        }


        used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

        q.Enqueue(u);
        Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
        while (q.Count != 0)
        {
          u = q.Peek();
          q.Dequeue();
          Console.WriteLine("Перешли к узлу {0}", u + 1);

          for (int i = 0; i < g.Length; i++)
          {
            if (Convert.ToBoolean(g[u][i]))
            {
              v = i;
              if (!used[v])
              {
                used[v] = true;
                q.Enqueue(v);
                Console.WriteLine("Добавили в очередь узел {0}", v + 1);
              }
            }
          }
        }
        Console.WriteLine("Завершить программу?");
        exit = Console.ReadLine();
        Console.Clear();
      } while (exit != "да" || exit != "if");
      Console.ReadKey();
    }

  }   
}

//http://c-sharp-snippet.blogspot.com/2015/02/bfs.html
