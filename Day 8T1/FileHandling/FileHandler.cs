using System;
using System.IO;
namespace Day8T1.FileHandling
{
    public class FileHandler
    {
        public void writeToFile(string name)// to write line
        {
        FileStream f = new FileStream("training.txt", FileMode.Create);  
        StreamWriter s = new StreamWriter(f);
        s.WriteLine(name);
        s.Close(); //closing streamwriter
        f.Close(); //closing file stram
        }

        public void readFromFile() //to read a file
        {
            FileStream f = new FileStream("training.txt", FileMode.Open);
            StreamReader reader = new StreamReader(f);
            string fileData=reader.ReadLine();
            System.Console.WriteLine(fileData);
            reader.Close();
            f.Close();
            System.Console.WriteLine("file read done successfully");

        }
    }
}