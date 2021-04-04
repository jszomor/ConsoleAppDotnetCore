using ConsoleAppDotnetCore;
using System;
using Xunit;

namespace XUnitTestPractice
{
  public class UnitTest1
  {
    [Fact]
    public void ShouldBeAnagrams()
    {
      string word1 = "abab";
      string word2 = "baba";

      Words words = new Words(word1, word2);
      var anag = new Anagram();
      bool isAnnagramm = anag.CompareAnagram(words);

      Assert.True(isAnnagramm);
    }

    [Fact]
    public void ShouldNotBeAnagrams()
    {
      string word1 = "ababa";
      string word2 = "baba";

      Words words = new Words(word1, word2);
      var anag = new Anagram();
      bool isAnnagramm = anag.CompareAnagram(words);

      Assert.False(isAnnagramm);
    }
  }
}
