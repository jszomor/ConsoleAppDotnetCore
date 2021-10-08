using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView
{
  public class StringsWorker
  {
    public static bool Test(string a, string b)
    {
      return a == b;      
    }


    //""
    //null
    //almaKörteBanan
    //AlmaKörteBanán
    //almaKörteB
    //alma

    public static List<string> SplitString(string input)
    {
      if (string.IsNullOrEmpty(input))
        return null;

      List<string> words = new List<string>();

      int marker = 0;

      for (int i = 1; i < input.Length; i++)
      {
        if(char.IsUpper(input[i]))
        {
          words.Add(input.Substring(marker, i - marker));
          marker = i;
        }        
      }

      words.Add(input.Substring(marker, input.Length - marker));
      return words;
    }

    public static List<string> SplitStringWhile(string input)
    {
      if (string.IsNullOrEmpty(input))
        return null;

      List<string> words = new List<string>();

      int end = input.Length;
      int start = 0;
      int position = 1;

      while(position <= end)
      {
        if(position == end || char.IsUpper(input[position]))
        {
          words.Add(input.Substring(start, position - start));
          start = position;
        }
        position++;
      }

      return words;
    }
  }
}
