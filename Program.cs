using System;
using System.Collections.Generic;

namespace part7lists
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Arthur Dent", "Marvin" };
            names.Add("Trillian");
            names.Add("Ford Prefect");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for (int i=0; i<names.Count; i+=1)
            {
                names[i] = names[i].ToUpper();
            }

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for (int i=0; i<3; i += 1)
            {
                Console.WriteLine("Input new name:");
                names.Add(Console.ReadLine().ToUpper());
            }

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"There are now {names.Count} names in the list.");

            Console.WriteLine("Input name to be removed:");
            string removal = Console.ReadLine().ToUpper();
            if (names.Remove(removal))
            {
                Console.WriteLine("Removed successfully.");
            }
            else
            {
                Console.WriteLine("Inputted name was not present. Input has been added to list.");
                names.Add(removal);
            }

            Console.WriteLine($"There are now {names.Count} names in the list.");

            names.Clear();
        }
    }
}
