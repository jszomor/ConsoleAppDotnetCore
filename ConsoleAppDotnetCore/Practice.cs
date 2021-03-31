using System;
using System.Collections.Generic;
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


      double L = Math.Sqrt(input.Length);
      Console.WriteLine(L);

      char[] a = new char[input.Length]; 

      int column = Convert.ToInt32(Math.Round(L, MidpointRounding.ToPositiveInfinity));
      int row = Convert.ToInt32(Math.Round(L, MidpointRounding.ToNegativeInfinity));

      for (int i = 0; i < column; i++)
      {
         //a = input[i];
      }

      return null;
    }
  }
}
