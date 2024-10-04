using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Create a list of 5 names and print them out
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
        Console.WriteLine("Part 1: List of names:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Part 2: Find the name in the 3rd position and print it
        Console.WriteLine("\nPart 2: Name in 3rd position:");
        Console.WriteLine(names[2]);

        // Part 3: Remove the name in the 2nd position and print the list
        names.RemoveAt(1);
        Console.WriteLine("\nPart 3: List after removing the 2nd name:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Part 4: Add a new name and print the list
        names.Add("Frank");
        Console.WriteLine("\nPart 4: List after adding a new name:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Part 5: Find the length of the list and print it
        Console.WriteLine("\nPart 5: Length of the list:");
        Console.WriteLine(names.Count);

        // Part 6: Check if a name exists in the list
        string searchName = "Charlie";
        Console.WriteLine($"\nPart 6: Does the name '{searchName}' exist in the list?");
        Console.WriteLine(names.Contains(searchName) ? "Yes" : "No");

        // Part 7: Find the index of a name and print it
        string findName = "David";
        Console.WriteLine($"\nPart 7: Index of the name '{findName}' in the list:");
        Console.WriteLine(names.IndexOf(findName));

        // Part 8: Insert a new name at the 3rd position and print the list
        names.Insert(2, "Grace");
        Console.WriteLine("\nPart 8: List after inserting a new name at the 3rd position:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Part 9: Sort the list and print it
        names.Sort();
        Console.WriteLine("\nPart 9: Sorted list:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // Part 10: Find the last index of a name and print it
        string lastIndexName = "Eve";
        int lastIndex = names.FindLastIndex(n => n == lastIndexName);
        Console.WriteLine($"\nPart 10: Last index of the name '{lastIndexName}': {lastIndex}");

        // Part 11: Clear the list and print it
        names.Clear();
        Console.WriteLine("\nPart 11: List after clearing:");
        if (names.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }

        // Part 12: Create a new list of strings and integers and print them
        List<object> mixedList = new List<object> { "John", 23, "Doe", 42, "Example", 19 };
        Console.WriteLine("\nPart 12: Mixed list of strings and integers:");
        foreach (var item in mixedList)
        {
            Console.WriteLine(item);
        }
    }
}
