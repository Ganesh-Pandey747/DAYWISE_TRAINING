namespace indexerp.employee
{
    public class Employee
    {
      private int Eid;
      public int Empid 
      {
          get
          {
              return Eid;
          }
          set
          {
              Eid = value; // value is a keyword
          }
      } 
    }
}