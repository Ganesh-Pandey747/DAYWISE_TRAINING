namespace day5.Models
{
    public class Employee
    {
      private int  Eid;
      private double salary;

      public int Employeeid  //properties
      {
         get  //Access
         { 
             return Eid;
         }
         set //Assign
         {
             Eid=value; //value is a reserved keyword to assign the data to variable
         }

      }
      public double Employeesalary  //properties
      {
         get  //Access
         { 
             return salary;
         }
         set //Assign
         {
             salary=value; //value is a reserved keyword to assign the data to variable
         }

      }


    }
}