using System;

namespace SoYouThinkYouCanLINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      #region President section

      var preses = new Presidents();


      foreach (var item in preses)
      {
        Console.WriteLine(item);

      }

      //behind the scene the complire rewrite the foreach loop similar to the below code
      using (var enumerator = preses.GetEnumerator())
      {
        while (enumerator.MoveNext())
          Console.WriteLine(enumerator.Current);
      }

      var alive = from p in preses
                  where p.IsAlive // Manual implementation of where function from LINQ
                  select p;

      var aliveWithoutLINQSyntax = preses.Where(preses.InstedOfLINQSyntax);


      Console.WriteLine();

      foreach (var item in alive)
      {
        Console.WriteLine(item);
      }


      Console.ReadKey();

      #endregion
    }
  }
}
