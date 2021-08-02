using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.GreedyAlgorithm
{
  public class ReverseShuffleMerge
  {
    public void Start()
    {
      //bdabaceadaedaaaeaecdeadababdbeaeeacacaba >> aaaaaabaaceededecbdb
      //djjcddjggbiigjhfghehhbgdigjicafgjcehhfgifadihiajgciagicdahcbajjbhifjiaajigdgdfhdiijjgaiejgegbbiigida >> aaaaabccigicgjihidfiejfijgidgbhhehgfhjgiibggjddjjd
      //abcdefgabcdefg >> bcdefga
      string s = "bdabaceadaedaaaeaecdeadababdbeaeeacacaba"; //aaaaaabaaceededecbdb
      char[] inputCharArray = s.ToCharArray();

      var inputString = new Dictionary<char, int>();
      foreach (var i in s)
      {
        if (inputString.ContainsKey(i))
        {
          inputString[i]++;
        }
        else
        {
          inputString.Add(i, 1);
        }
      }

      var usedLetter = new Dictionary<char, int>();
      var requiredLetter = new Dictionary<char, int>();

      foreach (var item in inputString)
      {
        if (inputString.TryGetValue(item.Key, out int value))
        {
          requiredLetter.Add(item.Key, value / 2);
        }
          usedLetter.Add(item.Key, 0);
      }

      char[] A = new char[inputCharArray.Length];
      int j = 0;
      for (int i = inputCharArray.Length - 1; i > 0; i--)
      {
        if (inputString[inputCharArray[i]] >= requiredLetter[inputCharArray[i]])
        {
          A[j] = inputCharArray[i];

          if (inputString.ContainsKey(A[j]))
          {
            inputString[A[j]]--;
            usedLetter[A[j]]++;
          }
        }

        //int numberOfRequiredLetters = requiredLetter[A[j]];
        //int numberOfUsedLetters = usedLetter[A[j]];

        while (j > 0 && A[j] < A[j - 1] && usedLetter[A[j - 1]] <= requiredLetter[A[j - 1]])
        {
          inputString[A[j - 1]]++;
          A[j - 1] = A[j];
          A[j] = '\0';
          j--;
        }

        j++;

      }


      foreach (var item in A)
      {
        Console.Write("{0},", item);
      }

      Console.ReadKey();
    }
  }
}
