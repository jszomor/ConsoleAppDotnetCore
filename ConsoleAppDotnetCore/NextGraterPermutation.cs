using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class NextGraterPermutation
  {

    public int[] NextLexicographical()
    {
      int[] nums = new[] { 0, 1, 2, 5, 3, 2, 0 };

      int i = nums.Length - 1;

      while (nums[i] <= nums[i - 1] && i > 0)
      {
        i--;
      }

      if (i <= 0)
        return null;

      int j = nums.Length - 1;
      
      while (nums[i - 1] >= nums[j])
      {
        j--;
      }

      int temp = nums[i - 1];
      nums[i - 1] = nums[j];
      nums[j] = temp;

      j = nums.Length - 1;

      while (i < j)
      {
        int subTemp = nums[i];
        nums[i] = nums[j];
        nums[j] = subTemp;
        i++;
        j--;
      }

      return nums;
    }
  }
}
