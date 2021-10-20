using Patterns.AbstractPattern;
using System;
using System.Collections.Generic;

namespace Patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      List<DataAccess> dataAccess = new()
      {
        new SqlDataAccess(),
        new SqlLiteDataAccess()
      };

      foreach (var item in dataAccess)
      {
        Console.WriteLine(item);
        Console.WriteLine(item.LoadData());
        Console.WriteLine(item.SaveData());
        Console.WriteLine(item.DeleteData());
        Console.WriteLine();
      }

      Console.ReadKey();
    }
  }
}
