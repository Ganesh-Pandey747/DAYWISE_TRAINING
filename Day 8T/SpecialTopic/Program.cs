using System;

namespace SpecialTopic
{
    class Program
    {
        
        public static void AddNumbers(int FirstNumber, int SecondNumber, params object[] restOfNumbers)
        {
            int result= FirstNumber+SecondNumber;
            if(restOfNumbers!=null)
            {
                foreach(int i in restOfNumbers)
                {
                    result+=i;
                }
            }
            System.Console.WriteLine("Sum="+ result);
        }

        public static void Main()
        {
           AddNumbers(10,20,30,40,50);

        }
    }
}
