﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS
{
  class Program
  {
    
    
    public class Employee
    {
      public Employee(string name)
      {
        this.name = name;
      }
      public string name { get; set; }


      public List<Employee> Employees
      {
        get
        {
          return EmployeeList;
        }
      }

      public void isEmployeeOf(Employee e)
      {
        EmployeeList.Add(e);
      }

      List<Employee> EmployeeList = new List<Employee>();

      public override string ToString()
      {
        return name;
      }
    }
    public class DepthFirstAlgorithm
    {
      public Employee BuildEmployyeGraph()
      {
        Employee Eva = new Employee("Eva");
        Employee Sophia = new Employee("Sophia");
        Employee Brian = new Employee("Brain");
        Eva.isEmployeeOf(Sophia);
        Eva.isEmployeeOf(Brian);

        Employee Lisa = new Employee("Lisa");
        Employee Tina = new Employee("Tina");
        Employee John = new Employee("John");
        Employee Mike = new Employee("Mike");
        Sophia.isEmployeeOf(Lisa);
        Sophia.isEmployeeOf(John);
        Brian.isEmployeeOf(Tina);
        Brian.isEmployeeOf(Mike);

        return Eva;
      }

      public Employee Search(Employee root, string nameToSearchFor)
      {
        if (nameToSearchFor ==root.name)
        {
          return root;
        }
        Employee personFound = null;
        for (int i = 0; i < root.Employees.Count; i++)
        {
          personFound = Search(root.Employees[i], nameToSearchFor);
          if (personFound != null)
            break;
        }
        return personFound;
      }
      public void Traverse(Employee root)
      {
        Console.WriteLine(root.name);
        for (int i = 0; i < root.Employees.Count; i++)
        {
          Traverse(root.Employees[i]);
        }
      }
    }


    static void Main(string[] args)
    {
      DepthFirstAlgorithm b = new DepthFirstAlgorithm();
      Employee root = b.BuildEmployyeGraph();
      Console.WriteLine("Traverse Graph\n----------");
      b.Traverse(root);

      Console.WriteLine("\nSearch in Graph\n---------------");
      Employee e = b.Search(root, "Eva");
      Console.WriteLine(e == null ? "Employee not found" : e.name);
      e = b.Search(root, "Brain");
      Console.WriteLine(e == null ? "Employee not found" : e.name);
      e = b.Search(root, "Soni");
      Console.WriteLine(e == null ? "Employee not found" : e.name);
      Console.ReadKey();
    }
  }
}
