using System;

class Taazaa
{
    public Taazaa()
    {
        Console.WriteLine("I am default constructor");
    }
    public Taazaa(string str):this()
    {
        Console.WriteLine(str);
    }
    static void Main()
    {
        var obj = new Taazaa("I am parameterized constructor");
    }
}