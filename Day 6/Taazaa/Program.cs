using System;
using Taazaa.Collections;
namespace Taazaa
{
    class Program
    {
        static void Main(string[] args)
        {
            var Can=new Candidates();
            var Str=Can.AddCandidatesName();
            Console.WriteLine(Str);
            Can.AddCandidatesNames();
        }
    }
}
