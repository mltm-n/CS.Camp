using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Addition("Meltem");

            Console.WriteLine(names.Length);
            names.Addition("Hacer");

            Console.WriteLine(names.Length);
            names.Addition("Zeynep");

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
