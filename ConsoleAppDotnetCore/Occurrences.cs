using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppDotnetCore
{
  public static class Occurrences
  {
    public static void CountWordOccurencyForLoop()
    {
      string[] words =
      {
          "which",
          "wristwatches",
          "are",
          "wristwatches",
          "wristwatches",
          "swiss",
          "wristwatches",
          "which",
          "are",
          "are",
          "wristwatches",
      };

      System.Array.Sort(words);
      string check = null;
      for (int i = 0; i < words.Length; i++)
      {
        int count = 1;
        for (int j = i + 1; j < words.Length; j++)
        {
          if (words[i] == words[j])
          {
            count++;
          }
          else break;
        }
        if (words[i] != check)
        {
          Console.WriteLine($"{words[i]}, {count}");
          check = words[i];
        }
      }
    }

    public static void FindSpecificWordInCollectionLINQ()
    {
      string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

      string searchTerm = "data";

      //Convert the string into an array of words  
      string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

      // Create the query.  Use ToLowerInvariant to match "data" and "Data"
      var matchQuery = from word in source
                       where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                       select word;

      // Count the matches, which executes the query.  
      int wordCount = matchQuery.Count();
      Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

      // Keep console window open in debug mode  
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    public static void WordCountDict()
    {
      string text = "1860 -as megválasztása előtt ügyvédként, Illinois állami tisztviselőként, kongresszusi képviselőként dolgozott, valamint kétszer jelöltette magát sikertelenül szenátornak.A rabszolgaság korlátozásáért agitáló kiváló szónokként[1] 1860 - ban elnyerte a Republikánus Párt elnökjelöltségét és még abban az évben megválasztották elnöknek. Programja ismeretében sikertelen kompromisszumkeresési folyamat után hét déli állam kilépett az Unióból. Lincoln ezt nem volt volt volt hajlandó tudomásul venni, pedig minden kivált állam legitim képviselők szavazása útján döntött a kiválásról, melyet több államban népszavazással is megerősítettek.A lázadónak nyilvánított délieket katonai erővel akarta leverni, s ezzel további négy állam kiválását okozta. Az Amerikai Konföderációs Államok milíciája erővel eltávolította területéről a távozást makacsul megtagadó unionista katonaságot, ezzel kirobbant az amerikai polgárháború. Lincoln sok területen tartotta kézben a háború vezetését. Az Amerikai Egyesült Államok főparancsnokaként sorra jelölte ki a hadműveleteket irányító tábornokokat, míg rá nem talált a sikereket biztosítani képes vezetőkre, mint például Ulysses S.Grant.A Republikánus Párt belügyeit jól kezelte, pártja hangadóit bevonta háborús kabinetjébe és kompromisszumos együttműködésre késztette őket.Lincoln sikeresen oldotta meg a Trent-incidens néven elhíresült diplomáciai nézeteltérést Anglia és az Egyesült Államok között 1861 - ben.Vezetése alatt a háború kezdetén az Unió irányítása alá kerültek a rabszolgatartó határállamok. Elnöksége idejére esett a 13.alkotmánykiegészítés és az 1863 -as emancipációs kiáltvány.A Republikánus Párt radikális szárnya kritizálta óvakodását a rabszolgaság betiltásától. A kritikákon retorikai tehetségét csillogtató beszédeivel sikerült túllendülnie.[2] 1863 -as gettysburgi beszéde a legismertebb amerikai szónoklat lett.[3] Az 1864 - es elnökválasztáson ismét neki szavaztak bizalmat.A polgárháborúban Északot győzelemre vezette és törvényileg eltörölte a rabszolgaságot. Hat nappal azután, hogy a déliek katonai főparancsnoka, Robert E. Lee letette a fegyvert, Lincolnnal egy merénylő golyója végzett. Ez volt az első eset, hogy amerikai elnök merénylet áldozatává vált.";

      string[] source = text.ToLower().Split(new char[] { '.', ',', '-', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

      var words = new Dictionary<string, int>();
      for (int i = 0; i < source.Length; i++)
      {
        if(!words.ContainsKey(source[i]))
        {
          words.Add(source[i], 1);
        }
        else
        {
          words[source[i]] += 1;
        }
      }

      var query = words.OrderByDescending(n => n.Value);

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"Word:{query.ElementAt(i).Key} -- Count:{query.ElementAt(i).Value}");
      }
    }


    public static void WordCountLINQ()
    {
      string text = "1860 -as megválasztása előtt ügyvédként, Illinois állami tisztviselőként, kongresszusi képviselőként dolgozott, valamint kétszer jelöltette magát sikertelenül szenátornak.A rabszolgaság korlátozásáért agitáló kiváló szónokként[1] 1860 - ban elnyerte a Republikánus Párt elnökjelöltségét és még abban az évben megválasztották elnöknek. Programja ismeretében sikertelen kompromisszumkeresési folyamat után hét déli állam kilépett az Unióból. Lincoln ezt nem volt volt volt hajlandó tudomásul venni, pedig minden kivált állam legitim képviselők szavazása útján döntött a kiválásról, melyet több államban népszavazással is megerősítettek.A lázadónak nyilvánított délieket katonai erővel akarta leverni, s ezzel további négy állam kiválását okozta. Az Amerikai Konföderációs Államok milíciája erővel eltávolította területéről a távozást makacsul megtagadó unionista katonaságot, ezzel kirobbant az amerikai polgárháború." +
                    "Lincoln sok területen tartotta kézben a háború vezetését. Az Amerikai Egyesült Államok főparancsnokaként sorra jelölte ki a hadműveleteket irányító tábornokokat, míg rá nem talált a sikereket biztosítani képes vezetőkre, mint például Ulysses S.Grant.A Republikánus Párt belügyeit jól kezelte, pártja hangadóit bevonta háborús kabinetjébe és kompromisszumos együttműködésre késztette őket.Lincoln sikeresen oldotta meg a Trent-incidens néven elhíresült diplomáciai nézeteltérést Anglia és az Egyesült Államok között 1861 - ben.Vezetése alatt a háború kezdetén az Unió irányítása alá kerültek a rabszolgatartó határállamok." +
                    "Elnöksége idejére esett a 13.alkotmánykiegészítés és az 1863 -as emancipációs kiáltvány.A Republikánus Párt radikális szárnya kritizálta óvakodását a rabszolgaság betiltásától. A kritikákon retorikai tehetségét csillogtató beszédeivel sikerült túllendülnie.[2] 1863 -as gettysburgi beszéde a legismertebb amerikai szónoklat lett.[3] Az 1864 - es elnökválasztáson ismét neki szavaztak bizalmat.A polgárháborúban Északot győzelemre vezette és törvényileg eltörölte a rabszolgaságot. Hat nappal azután, hogy a déliek katonai főparancsnoka, Robert E. Lee letette a fegyvert, Lincolnnal egy merénylő golyója végzett. Ez volt az első eset, hogy amerikai elnök merénylet áldozatává vált.";

      string[] source = text.ToLower().Split(new char[] { '.', ',', ' ', '?', '!', '/', '-' }, StringSplitOptions.RemoveEmptyEntries);

      var query = (from i in source
                   group i by i into g
                   orderby g.Count() descending
                   select new { g.Key, count = g.Count() }).ToList();

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(query[i]);
      }
      Console.WriteLine("==================================");
    }

    public static void WordCountLINQ2()
    {
      string[] texts = new string[]
      {
        "1860 -as megválasztása előtt ügyvédként, Illinois állami tisztviselőként, kongresszusi képviselőként dolgozott, valamint kétszer jelöltette magát sikertelenül szenátornak.A rabszolgaság korlátozásáért agitáló kiváló szónokként[1] 1860 - ban elnyerte a Republikánus Párt elnökjelöltségét és még abban az évben megválasztották elnöknek. Programja ismeretében sikertelen kompromisszumkeresési folyamat után hét déli állam kilépett az Unióból. Lincoln ezt nem volt hajlandó tudomásul venni, pedig minden kivált állam legitim képviselők szavazása útján döntött a kiválásról, melyet több államban népszavazással is megerősítettek.A lázadónak nyilvánított délieket katonai erővel akarta leverni, s ezzel további négy állam kiválását okozta. Az Amerikai Konföderációs Államok milíciája erővel eltávolította területéről a távozást makacsul megtagadó unionista katonaságot, ezzel kirobbant az amerikai polgárháború."+
                    "Lincoln sok területen tartotta kézben a háború vezetését. Az Amerikai Egyesült Államok főparancsnokaként sorra jelölte ki a hadműveleteket irányító tábornokokat, míg rá nem talált a sikereket biztosítani képes vezetőkre, mint például Ulysses S.Grant.A Republikánus Párt belügyeit jól kezelte, pártja hangadóit bevonta háborús kabinetjébe és kompromisszumos együttműködésre késztette őket.Lincoln sikeresen oldotta meg a Trent-incidens néven elhíresült diplomáciai nézeteltérést Anglia és az Egyesült Államok között 1861 - ben.Vezetése alatt a háború kezdetén az Unió irányítása alá kerültek a rabszolgatartó határállamok."+
                    "Elnöksége idejére esett a 13.alkotmánykiegészítés és az 1863 -as emancipációs kiáltvány.A Republikánus Párt radikális szárnya kritizálta óvakodását a rabszolgaság betiltásától. A kritikákon retorikai tehetségét csillogtató beszédeivel sikerült túllendülnie.[2] 1863 -as gettysburgi beszéde a legismertebb amerikai szónoklat lett.[3] Az 1864 - es elnökválasztáson ismét neki szavaztak bizalmat.A polgárháborúban Északot győzelemre vezette és törvényileg eltörölte a rabszolgaságot. Hat nappal azután, hogy a déliek katonai főparancsnoka, Robert E. Lee letette a fegyvert, Lincolnnal egy merénylő golyója végzett. Ez volt az első eset, hogy amerikai elnök merénylet áldozatává vált."

      };

      var result = (from line in texts
                    let words = line.ToLower().Split(new char[] { '.', ',', ' ', '?', '!', '/', ';', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    from word in words
                    group word by word into g
                    orderby g.Count() descending
                    select new { g.Key, Occurance = g.Count() }).ToList();

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(result[i]);
      }
    }
  }
}
