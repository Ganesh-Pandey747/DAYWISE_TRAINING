using System;
using Taazaa1.TrainingList;
using Taazaa1.Models;
using System.Collections.Generic;

namespace Taazaa1
{
    class Program
    {
        static void Main()
        {
        var obj1=new TaazaTrainingList();
           List<Details> temp=obj1.TrainingList();
           int n=temp.Count;
           for(int i=0;i<n;i++)
           {
               Console.WriteLine(temp[i].Email +" "+ temp[i].PhoneNumber);
           }

        
            
        }
    }
}
