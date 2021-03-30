using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class Practice
  {
    public string AppendAndDelete(string s, string t, int k)
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


  }
}
