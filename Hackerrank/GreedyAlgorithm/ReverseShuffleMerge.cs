using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.GreedyAlgorithm
{
  public class ReverseShuffleMerge
  {
    public string Start()
    {
      //bdabaceadaedaaaeaecdeadababdbeaeeacacaba >> aaaaaabaaceededecbdb
      //djjcddjggbiigjhfghehhbgdigjicafgjcehhfgifadihiajgciagicdahcbajjbhifjiaajigdgdfhdiijjgaiejgegbbiigida >> aaaaabccigicgjihidfiejfijgidgbhhehgfhjgiibggjddjjd
      //abcdefgabcdefg >> bcdefga
      string s = "djjcddjggbiigjhfghehhbgdigjicafgjcehhfgifadihiajgciagicdahcbajjbhifjiaajigdgdfhdiijjgaiejgegbbiigida"; 
      char[] inputCharArray = s.ToCharArray();

      var unusedLetters = new Dictionary<char, int>();
      foreach (var i in s)
      {
        if (unusedLetters.ContainsKey(i))
        {
          unusedLetters[i]++;
        }
        else
        {
          unusedLetters.Add(i, 1);
        }
      }

      var usedLetters = new Dictionary<char, int>();
      var requiredLetter = new Dictionary<char, int>();

      foreach (var item in unusedLetters)
      {
        if (unusedLetters.TryGetValue(item.Key, out int value))
        {
          requiredLetter.Add(item.Key, value / 2);
        }
        usedLetters.Add(item.Key, 0);
      }

      char[] A = new char[inputCharArray.Length / 2];
      int j = 0;
      for (int i = inputCharArray.Length - 1; i >= 0; i--)
      {

        if(j == 19)
        {
          Console.WriteLine();
        }

        if (unusedLetters[inputCharArray[i]] > requiredLetter[inputCharArray[i]])
        {
          A[j] = inputCharArray[i];

          //if (unusedLetters.ContainsKey(A[j]))
          {
            unusedLetters[A[j]]--;
            usedLetters[A[j]]++;
          }

          while (j > 0 && A[j] < A[j - 1] && usedLetters[A[j - 1]] <= requiredLetter[A[j - 1]])
          {
            unusedLetters[A[j - 1]]++;
            A[j - 1] = A[j];
            A[j] = '\0';
            j--;
          }

          j++;
        }
      }

      string result = string.Concat(A);



      foreach (var item in A)
      {
        Console.Write("{0},", item);
      }

      Console.ReadKey();


      return result;
    }
  }
}
