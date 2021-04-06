using System;

namespace ConsoleAppDotnetCore
{
  class Program
  {
    static void Main(string[] args)
    {


      string[] _Words = new string[]
      {
        "Historically", "the", "world", "other", "in", "string", "the", "world", "world", "world", "the",
        "in", "Historically", "world", "in", "the", "the", "the", "the", "the", "in", "in", "world"
      };

      //Practice.CountWordOccuranceDict(_Words);

      Practice.CountOccuranceLINQ(_Words);

            //Occurrences.CountWordOccurencyForLoop();

      //Occurrences.FindSpecificWordInCollectionLINQ();

      //Occurrences.CountWordDict();

      //int[] numbers = new int[] { 10, 1, 4, 6, 6, 3, 9, 12 };

      //var binaryTree = new BinaryTree(numbers);
      //binaryTree.InOrder(binaryTree.Print);

      //var quickSort = new MyArray(numbers);

      //quickSort.Sort();

      //foreach (var item in numbers)
      //{
      //  Console.WriteLine(item);
      //}

      //while(true)
      //{
      //  Console.WriteLine("Enter the first word.");
      //  string word1 = Console.ReadLine();
      //  Console.WriteLine("Enter the second word.");
      //  string word2 = Console.ReadLine();

      //  Words words = new Words(word1, word2);
      //  var anag = new Anagram();
      //  anag.CompareAnagram(words);
      //  string answer;
      //  while (true)
      //  {
      //    Console.WriteLine("Wants to try again?(Y/N)");
      //    answer = Console.ReadLine();

      //    if (answer != "Y" && answer != "N")
      //    {
      //      Console.WriteLine("Invalid answer. Please select letter [Y] for keep continue or letter [N] for exit");
      //    }
      //    else
      //      break;
      //  }

      //  if (answer == "N")
      //    break;
      //}

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
