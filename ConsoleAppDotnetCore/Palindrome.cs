using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class Palindrome
  {
    public bool Check(string word)
    {

      char[] wordChar = word.ToCharArray();

      int j = wordChar.Length - 1;

      for (int i = 0; i < word.Length / 2; i++)
      {
        char temp = wordChar[i];
        wordChar[i] = wordChar[j];
        wordChar[j] = temp;

        j--;
      }

      string wordReverse = new string(wordChar);

      if (wordReverse == word)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}
