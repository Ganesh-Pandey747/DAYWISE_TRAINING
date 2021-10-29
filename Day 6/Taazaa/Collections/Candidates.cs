using System;
using System.Collections;
using System.Collections.Generic;
namespace Taazaa.Collections
{
    public class Candidates
    {
       public string AddCandidatesName()
       {
           ArrayList arrayList=new ArrayList();
           arrayList.Add("Ganesh");// boxing
           arrayList.Add("Ganesh Pandey");
           string Name=(string)arrayList[1];// unboxing
           //Console.WriteLine(Name);
           return Name;

       }
       public void AddCandidatesNames()
       {
           List<string> obj=new List<string>();
           obj.Add("Shubham");
           obj.Add("Shubham Pandey");
           if(obj.Contains("Shubham"))
           {
               Console.WriteLine("Found");
           }
           else
           {
               Console.WriteLine("Not found");
           }

           
       }
    }
}