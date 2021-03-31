using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public static class Practice
  {
    public static string AppendAndDelete(string s, string t, int k)
    {

      if(s == t)
      {
        return "Yes";
      }

      else if(s == t && s.Length + t.Length <= k)
      {
        return "Yes";
      }

      else if(s.Length > t.Length && s.Length + t.Length <= k)
      {
        return "Yes";
      }

      else
      {
        return "No";
      }




      //TestCases

      //(the initial string) s = asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv
      //(the desired string) t = bsdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv
      //k = 100
      //"No"
      //8. testCase

      //s = asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv
      //t = asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv
      //k = 20
      //"Yes"
      //7. testCase

      //s = uoiauwrebgiwrhgiuawheirhwebvjforidkslweufgrhvjqasw
      //t = vgftrheydkoslwezxcvdsqjkfhrydjwvogfheksockelsnbkeq
      //k = 100
      //"Yes"
      //11. testCase
    }


    public static string Encryption(string input)
    {

      //string input = "haveaniceday";
      //output: hae and via ecy

      //feedthedog
      //fto ehg ee dd

      //chillout
      //clu hlt io

      double L = Math.Sqrt(input.Length);
      Console.WriteLine(L);

      var builder = new StringBuilder();
      int column = Convert.ToInt32(Math.Ceiling(L));
      int row = Convert.ToInt32(Math.Floor(L));
      for (int j = 0; j < column; j++)
      {
        for (int i = j; i < input.Length; i+=column)
        {
          builder.Append(input[i]);
        }
        builder.Append(" ");
      }

      return Convert.ToString(builder);
    }

    public static string TheBiggerIsGreater(string input)
    {



      // Convert to char array.
      char[] a = input.ToCharArray();

      // Sort letters.
      Array.Sort(a);

      string output = new string(a);
      // Return modified string.
      return output;

    }
  }
}
