using System.Collections.Generic;
using System;
using Taazaa1.Models;
namespace Taazaa1.TrainingList
{
    public class TaazaaTrainingList
    {
        public  List<Details> TrainingList()
        {
           List<Details> obj= new List<Details>();
           obj.Add(new Details{
               Email="ganesh747@gmail.com",
               PhoneNumber=747
           });

           obj.Add(new Details{
               Email="ganesh747.com",
               PhoneNumber=999

           });
           return obj;

        }
    }
}