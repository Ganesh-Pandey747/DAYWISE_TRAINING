using System;

namespace MajorLogicApplication
{
    public class Employee
    {
        private object[] data=new object[2];//variable name is data and done indexing with 2 two subscript. ex-data[0]=101,data[1]="Ganesh"
        //indexer is referred by this keyword

        public object this[int i]// this referred to employee object
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i]=value;
            }
        }
    }  

    class Program
    {
        public static void Main()
        {
            Employee employee=new Employee();
            employee[0]=101;//set  //data[0]=employee[0], data[1]=employee[1]
            employee[1]="Ganesh";//set

            System.Console.WriteLine(employee[0]+" " +employee[1]);//get

        }
    }
}
