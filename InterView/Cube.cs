using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class Cube
  {
    public static void DropCube()
    {
      var r = new Random();

      Console.WriteLine("Press a and hit enter to drop the cube");
      Console.WriteLine("Press any other key and hit enter to exit");

      int total = 0;

      while (true)
      {
        var dropKey = Console.ReadLine();
        var number = r.Next(1, 7);

        if (dropKey == "a")
        {
          Console.WriteLine($"     {number} >> Total: {total += number}");

          if (number == 6)
          {
            dropKey = Console.ReadLine();
            number = r.Next(1, 7);

            Console.WriteLine($"     {number} >> Total: {total += number}");

            if (number == 6)
            {
              total = 0;
            }
          }
        }
        else
        {
          break;
        }
      }
    }
  }
}
