using System;
using System.Collections.Generic;

namespace CS.Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Meltem", "Hacer", "Şeyma" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names.Add("Zeynep");
            Console.WriteLine(names[3]);
            Console.WriteLine(names[0]);
        }
    }
}
