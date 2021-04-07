using System;
using System.Linq;

namespace ConsoleAppDotnetCore
{
  class Program
  {
    static void Main(string[] args)
    {

      int num2 = 1234, r;
      while (num2 > 0)
      {
        r = num2 % 10;
        num2 = num2 / 10;
        Console.WriteLine(+r);
      }


      bool OxB = Convert.ToBoolean(Convert.ToInt32(0xc));
      bool OZZ = Convert.ToBoolean(Convert.ToInt32(022));
      bool xeb = Convert.ToBoolean(Convert.ToInt32('\xeb'));


      int a = Convert.ToInt32(0xc);
      int b = Convert.ToInt32(022);
      int c = Convert.ToInt32('\xc');

      if (OxB)
        if (OZZ)
          if (xeb)
            Console.WriteLine("If executed Successfully");
          else;
        else;
      else;


      int a2 = 1, b2 = 2;

      //a2 = Convert.ToInt32(++a2);
      //b2 = Convert.ToInt32(++b2);

      if (Convert.ToBoolean(Convert.ToInt32(++a2)) || Convert.ToBoolean(Convert.ToInt32(++b2)))
      {
        Console.WriteLine(a2 + "\n" + b2);
      }
      else
        Console.WriteLine(" C# questions ");




      int i;
      int div = 8, num = 32;
      for (i = 0; i <= 10; i++)
      {
        if ((num / div * 3) == 6)
        {
          Console.WriteLine(i + " ");
          continue;
        }
        else if (i != 5)
          Console.Write(i + " ");
        else
          break;
      }
      Console.ReadLine();

      //string abc = "abc";

      //var query = from letter in abc
      //            let a = letter.ToString().ToLower().OrderBy(x => x)
      //            select a;

      //string[] _Words = new string[]
      //{
      //  "Historically", "the", "world", "other", "in", "string", "the", "world", "world", "world", "the",
      //  "in", "Historically", "world", "in", "the", "the", "the", "the", "the", "in", "in", "world"
      //};

      //Practice.CountWordOccuranceDict(_Words);

      //Practice.CountOccuranceLINQ(_Words);

      //Console.WriteLine(Practice.FibonacciLinear(30));

      //Occurrences.CountWordOccurencyForLoop();

      //Occurrences.FindSpecificWordInCollectionLINQ();

      //Occurrences.CountWordDict();

      //int[] numbers = new int[] { 10, 1, 4, 6, 6, 3, 9, 12 };

      //var linkedList = new LinkedList(numbers);

      //var binaryTree = new BinaryTree(numbers);
      //binaryTree.InOrder(binaryTree.Print);

      //var aaronjwood = new aaronjwoodBinarySearchTree.BinarySearchTree();
      //aaronjwood.Start();

      //var quickSort = new MyArray(numbers);

      //quickSort.Sort();

      //foreach (var item in numbers)
      //{
      //  Console.WriteLine(item);
      //}


      var anag = new Anagram();
      anag.Start(anag);

      //Occurrences.WordCountLINQ2();

      //string input = "haveaniceday";

      //Console.WriteLine(Practice.Encryption(input));

      //abchgfeaaaa

      //no >>> dcba
      //no >>> dcbb

      //string input2 = "dcbb";

      //Console.WriteLine(Practice.TheBiggerIsGreater2(input2));

      //var practice = new Practice();

      //string s = "aaaaaaaaaa"; //"asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv"; // "hackerhappy"; //Console.ReadLine();

      //string t = "aaaaa"; //"asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv"; //"hackerrank"; //Console.ReadLine();

      //int k = 7; //9;  //Convert.ToInt32(Console.ReadLine());


      //string result = practice.AppendAndDelete(s, t, k);

      //Console.WriteLine(result);
      //Console.WriteLine("Hello World!");

      //WeekOfCode25._2_AppendAndDelete(s, t, k);
    }
  }
}
