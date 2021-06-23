using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppDotnetCore
{
  //public class BaseballTeam
  //{



  //  private string[] players = new string[9];
  //  private readonly List<string> positionAbbreviations = new List<string>
  //      {
  //          "P", "C", "1B", "2B", "3B", "SS", "LF", "CF", "RF"
  //      };

  //  public string this[int position]
  //  {
  //    // Baseball positions are 1 - 9.
  //    get { return players[position - 1]; }
  //    set { players[position - 1] = value; }
  //  }
  //  public string this[string position]
  //  {
  //    get { return players[positionAbbreviations.IndexOf(position)]; }
  //    set { players[positionAbbreviations.IndexOf(position)] = value; }
  //  }
  //}

  class Program
  {

    //  static int X { get; set; } = 5;
    //  static int Y = 10;

    //  private Program()
    //  {

    //  }

    //  static void ABC()
    //  {

    //  }
    //  static public void Method(int refArgument)
    //  {
    //    refArgument = refArgument + 44;
    //  }

    static void Main(string[] args)
    {

      //double resultLoop = Practice.FibonacciLoop(3);
      //double resultRec = Practice.FibonacciRec(3);
      //Console.WriteLine($"loop: {resultLoop} -- recucrion: {resultRec}");



      double result =  Practice.FactorialYoutubeKudvenkat2(5);
      Console.WriteLine(result);
      Console.ReadKey();



      //var next = new NextGraterPermutation();
      //next.NextLexicographical();

      //    int number = 1;
      //    Method(number);
      //    Console.WriteLine(number);


      //    var team = new BaseballTeam
      //    {
      //      ["RF"] = "Mookie Betts",
      //      [4] = "Jose Altuve",
      //      ["CF"] = "Mike Trout"
      //    };

      //    Console.WriteLine(team[4]);


      //    uint x2 = 10;

      //    uint y2 = x2 >> 1;

      //    Console.WriteLine($"{Program.X}, {Program.Y}");

      //    Program.ABC();

      //    int i3 = 1, j3 = 1;
      //    while (++i3 <= 10)
      //    {
      //      j3++;
      //    }
      //    Console.WriteLine(i3 + "  " + j3);


      //  int i = 30;
      //    int j = 5 % 5;
      //    double z = Convert.ToInt32(i >= j); // success

      //    if (Convert.ToBoolean(Convert.ToInt32(i != j)))
      //    {
      //      Console.WriteLine("if Clause executed");
      //    }
      //    else
      //    {
      //      Console.WriteLine("else Clause executed");
      //    }
      //    Console.WriteLine("Entered Main Function");
      //    Console.ReadLine();


      //    int num2 = 1234, r;
      //    while (num2 > 0)
      //    {
      //      r = num2 % 10;
      //      num2 = num2 / 10;
      //      Console.WriteLine(+r);
      //    }


      //    bool OxB = Convert.ToBoolean(Convert.ToInt32(0xc));
      //    bool OZZ = Convert.ToBoolean(Convert.ToInt32(022));
      //    bool xeb = Convert.ToBoolean(Convert.ToInt32('\xeb'));


      //    int a = Convert.ToInt32(0xc);
      //    int b = Convert.ToInt32(022);
      //    int c2 = Convert.ToInt32('\xc');

      //    if (OxB)
      //      if (OZZ)
      //        if (xeb)
      //          Console.WriteLine("If executed Successfully");
      //        else;
      //      else;
      //    else;


      //    int a2 = 1, b2 = 2;

      //    //a2 = Convert.ToInt32(++a2);
      //    //b2 = Convert.ToInt32(++b2);

      //    if (false || Convert.ToBoolean(Convert.ToInt32(++b2)))
      //    {
      //      Console.WriteLine(a2 + "\n" + b2);
      //    }
      //    else
      //      Console.WriteLine(" C# questions ");




      //int e;
      //int div = 8, num = 32;
      //for (e = 0; e <= 10; e++)
      //{
      //  if ((num / div * 3) == 6)
      //  {
      //    Console.WriteLine(e + " ");
      //    continue;
      //  }
      //  else if (e != 5)
      //    Console.Write(i + " ");
      //  else
      //    break;
      //}
      //Console.ReadLine();

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


      //var anag = new Anagram();
      //anag.Start(anag);

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
