using System;
using System.Linq; // For the Contains and IndexOf methods

class Program
{
    static void Main(string[] args)
    {
        //---------------------------------------------------------------------
        // Part 1: Create an array of 5 countries and print them out
        string[] countries = new string[5] { "USA", "Canada", "Mexico", "Brazil", "Argentina" };
        Console.WriteLine("Part 1: List of countries:");
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        //---------------------------------------------------------------------
        // Part 2: Access the name in the 3rd position and print it
        Console.WriteLine("\nPart 2: Country in 3rd position:");
        Console.WriteLine(countries[2]);  // Index 2 is the 3rd position

        //---------------------------------------------------------------------
        // Part 3: Removing an element from the array (Arrays cannot have elements removed in C#)
        // Instead of removing, we can replace the element with a placeholder.
        Console.WriteLine("\nPart 3: Simulating removal of country in 2nd position (replace with empty):");
        countries[1] = "";  // Arrays have fixed size, so we can't actually "remove" an item.
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        //---------------------------------------------------------------------
        // Part 4: Replace the name in the 3rd position with a new name
        Console.WriteLine("\nPart 4: Replace the 3rd country with 'Chile':");
        countries[2] = "Chile";
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }

        //---------------------------------------------------------------------
        // Part 5: Find the length of the array and print it
        Console.WriteLine("\nPart 5: Length of the array:");
        Console.WriteLine(countries.Length);

        //---------------------------------------------------------------------
        // Part 6: Check if a name exists in the array
        string searchCountry = "Brazil";
        Console.WriteLine($"\nPart 6: Does '{searchCountry}' exist in the array?");
        Console.WriteLine(countries.Contains(searchCountry) ? "Yes" : "No");

        //---------------------------------------------------------------------
        // Part 7: Find the index of a name in the array
        string findCountry = "Argentina";
        Console.WriteLine($"\nPart 7: Index of '{findCountry}' in the array:");
        Console.WriteLine(Array.IndexOf(countries, findCountry));
    }
}
