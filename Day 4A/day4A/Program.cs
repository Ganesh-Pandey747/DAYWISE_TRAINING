
using System;
using day4A.Study; 
using day4A.Movie;
namespace day4A
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudy obj =new Ganesh_study();
            string temp= obj.Study();
            Console.WriteLine(temp);

            IMovie obj1 =new Ganesh_movie();
            int temp2= obj1.Movie();
            Console.WriteLine(temp2);
        }
    }
}
