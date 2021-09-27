using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Text;

namespace InterView.InterfacePractice
{
  public class DoSomething : IDoSomething, IDoSomethingElse
  {


    public void f()
    {


      //try
      {
        MemberInfo[] myMemberInfo;
        //var myObject = new DoSomething();

        // Get the type of 'MyClass'.
        Type myType = this.GetType();

        var interf = this.GetType().GetInterfaces();

        // Get the information related to all public member's of 'MyClass'.
        myMemberInfo = myType.GetMembers();

        Console.WriteLine(myMemberInfo[0].Name);


        foreach (var item in interf)
        {
          Console.WriteLine(item);
        }





        //Console.WriteLine("\nThe members of class '{0}' are :\n", myType);
        //for (int i = 0; i < myMemberInfo.Length; i++)
        //{
        //  // Display name and type of the concerned member.
        //  Console.WriteLine("'{0}' is a {1}", myMemberInfo[i].Name, myMemberInfo[i].MemberType);
        //}
      }
      //catch (SecurityException e)
      //{
      //  Console.WriteLine("Exception : " + e.Message);
      //}
    } 

    public void g()
    {
      MemberInfo[] myMemberInfo;
      //var myObject = new DoSomething();

      // Get the type of 'MyClass'.
      Type myType = this.GetType();

      myMemberInfo = myType.GetMembers();
      Console.WriteLine();

      Console.WriteLine(myMemberInfo[1].Name);
    }
  }
}
