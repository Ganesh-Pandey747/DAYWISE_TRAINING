using System;
using Practice.Collections;
using AssignmentDay8.Contact;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
          
          var obj=new  ContactLists();
          var list=obj.CreateContact();
         // List<Contact> obj1=obj.CreateContact();
          int count=list.Count;
          for(int i=0;i<count;i++)
          {
               System.Console.WriteLine(list[i].contactId+" "+list[i].ContactName+" "+list[i].ContactPhoneNumber);
          }
          var mod=obj.Modify();
          int count1=mod.Count;
          for(int i=0;i<count1;i++)
          {
               System.Console.WriteLine(list[i].contactId+" "+list[i].ContactName+" "+list[i].ContactPhoneNumber);
          }
          obj.Search();
          var del=obj.deleteContact();
          int count2=del.Count;

          for(int i=0;i<count;i++)
          {
               System.Console.WriteLine(list[i].contactId+" "+list[i].ContactName+" "+list[i].ContactPhoneNumber);
          }
          var update=obj.updateContact();
          var count3=update.Count;
          for(int i=0;i<count;i++)
          {
               System.Console.WriteLine(list[i].contactId+" "+list[i].ContactName+" "+list[i].ContactPhoneNumber);
          }

        }
    }
}