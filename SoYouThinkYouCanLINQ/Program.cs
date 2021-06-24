using System;
using System.Linq;

namespace SoYouThinkYouCanLINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      #region President section

      //var preses = new Presidents();


      //foreach (var item in preses)
      //{
      //  Console.WriteLine(item);

      //}

      ////behind the scene the complire rewrite the foreach loop similar to the below code
      //using (var enumerator = preses.GetEnumerator())
      //{
      //  while (enumerator.MoveNext())
      //    Console.WriteLine(enumerator.Current);
      //}

      //var alive = from p in preses
      //            where p.IsAlive // Manual implementation of where function from LINQ
      //            select p;

      //var aliveWithoutLINQSyntax = preses.Where(preses.InstedOfLINQSyntax);


      //Console.WriteLine();

      //foreach (var item in alive)
      //{
      //  Console.WriteLine(item);
      //}


      //Console.ReadKey();

      #endregion

      #region Anonymus delegates

      int[] num = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      var result = num.Where(SampleMethods.MyPredicate);

      var result2 = num.Where(n => n % 2 == 0);

      var result3 = num.Where(delegate(int num)
      {
        return num % 2 == 0;
      });

      Func<int, bool> myDel = delegate (int num)
      {
        return num % 2 == 0;
      };

      var result4 = num.Where(myDel);


      foreach (var item in result4)
      {
        Console.WriteLine(item);
      }


      //TransformDelegate a, b, c, d;

      //a = SamleMethods.Method1;

      //b = SamleMethods.Method2;

      //c = a + b; //delegates have multicast feature

      //d = c - a;

      //d("b");

      Console.ReadKey();

      #endregion
    }
  }
}
