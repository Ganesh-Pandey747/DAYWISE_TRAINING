using Day8T1.FileHandling;
using System;
namespace Day8T1
{
    class Program
    {
        static void Main()
        {
            FileHandler fileHandler= new FileHandler(); // object name is filehandler
            fileHandler.writeToFile("Ganesh Pandey");
            fileHandler.readFromFile();
        }
    }
}
