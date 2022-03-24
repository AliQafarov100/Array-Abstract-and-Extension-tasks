using System;
using Search_with_Extensions.Extension_method;

namespace Search_with_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bu bir custom contains methodudur";
            Console.WriteLine(name.customContains("Bu"));
            Console.WriteLine(name.customContains("bu"));
            Console.WriteLine(name.customContains("tains"));
            Console.WriteLine(name.customContains("ns Methodudur"));
            Console.WriteLine(name.customContains("bu bir custom"));
        }
    }
}
