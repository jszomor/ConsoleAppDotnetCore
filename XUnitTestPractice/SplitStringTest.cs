using InterView;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestPractice
{
  public class SplitStringTest
  {

    //almaKörteBanan
    //AlmaKörteBanán
    //almaKörteB
    //alma
    [Theory]
    [InlineData("almaKörteBanan", new[] { "alma", "Körte", "Banan"})]
    [InlineData("AlmaKörteBanan", new[] { "Alma", "Körte", "Banan" })]
    [InlineData("almaKörteB", new[] { "alma", "Körte", "B" })]
    [InlineData("alma", new[] { "alma" })]
    public void TestSplitString(string input, string[] expected)
    {
      var actual =  StringsWorker.SplitStringWhile(input);

      Assert.Equal(expected, actual);
    }
  }
}
