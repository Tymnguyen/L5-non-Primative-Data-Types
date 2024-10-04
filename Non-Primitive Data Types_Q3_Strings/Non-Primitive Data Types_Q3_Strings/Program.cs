using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////////// String Operations ////////////////////////////

        // Part 1: Concatenate three strings and convert to uppercase
        string part1Str1 = "Hello", part1Str2 = "World", part1Str3 = "CSharp";
        Console.WriteLine("\nPart 1: Concatenate and Uppercase: " + (part1Str1 + part1Str2 + part1Str3).ToUpper());

        // Part 2: Concatenate three strings and convert to lowercase
        Console.WriteLine("\nPart 2: Concatenate and Lowercase: " + (part1Str1 + part1Str2 + part1Str3).ToLower());

        // Part 3: Find the length of a string
        Console.WriteLine("\nPart 3: Length of string '" + part1Str1 + "' is: " + part1Str1.Length);

        // Part 4: Find the index of a character in a string
        Console.WriteLine("\nPart 4: Index of 'o' in '" + part1Str1 + "' is: " + part1Str1.IndexOf('o'));

        // Part 5: Find the index of a character starting from a specified position
        Console.WriteLine("\nPart 5: Index of 'o' in '" + part1Str1 + "' starting from index 2 is: " + part1Str1.IndexOf('o', 2));

        // Part 6: Count occurrences of a specific character in a string
        char targetChar = 'o';
        Console.WriteLine("\nPart 6: Occurrences of '" + targetChar + "' in '" + part1Str1 + "' is: " + part1Str1.Count(c => c == targetChar));

        // Part 7: Replace a character in a string
        Console.WriteLine("\nPart 7: Replace 'l' with 'x' in '" + part1Str1 + "' : " + part1Str1.Replace('l', 'x'));

        // Part 8: Remove a character from a string
        Console.WriteLine("\nPart 8: Remove character at index 1 from '" + part1Str1 + "' : " + part1Str1.Remove(1, 1));

        // Part 9: Replace all occurrences of a character in a string
        Console.WriteLine("\nPart 9: Replace all 'o' with 'a' in '" + part1Str1 + "' : " + part1Str1.Replace('o', 'a'));

        // Part 10: Extract a substring from a string
        Console.WriteLine("\nPart 10: Substring of '" + part1Str1 + "' from index 1: " + part1Str1.Substring(1));

        // Part 11: Extract a substring from a string starting from a specified position
        Console.WriteLine("\nPart 11: Substring of '" + part1Str1 + "' from index 1 of length 3: " + part1Str1.Substring(1, 3));

        // Part 12: Remove leading and trailing whitespace from a string
        string part12Str = "   Trimmed String   ";
        Console.WriteLine("\nPart 12: Trimmed string: '" + part12Str.Trim() + "'");

        // Part 13: Parse a string to a number
        string numberStr = "12345";
        int number = int.Parse(numberStr);
        Console.WriteLine("\nPart 13: Parsed number: " + number);

        // Part 14: Convert a number to a string
        int num = 67890;
        Console.WriteLine("\nPart 14: Converted number to string: " + num.ToString());

        //////////////////////////// Formatting Operations ////////////////////////////

        // Part 1: Personalized event invitation
        string recipientName = "Alice";
        string eventDate = "January 15, 2025";
        string eventTime = "09:00";
        Console.WriteLine($"\nHello, {recipientName}! You're invited to our team outing on {eventDate}. The event starts at {eventTime}.");

        // Part 2: Order confirmation email
        string customerName = "John Doe";
        string orderId = "123456";
        string purchaseDetails = "2 x T-shirts, 3 x Jeans";
        Console.WriteLine($"\nDear {customerName}, your order (ID: {orderId}) has been confirmed. You've purchased: {purchaseDetails}.");

        // Part 3: Task reminder
        string taskName = "Complete Project Proposal";
        string dueDate = "May 10, 2025";
        string priority = "High";
        Console.WriteLine($"\nReminder: {taskName} is due on {dueDate}. Priority: {priority}.");

        // Part 4: Event reminder
        string eventTitle = "Team Meeting";
        string eventLocation = "Conference Room A";
        string startTime = "10:00 AM";
        Console.WriteLine($"\nReminder: {eventTitle} at {eventLocation} starts at {startTime}.");

        // Part 5: Flight departure information
        string flightNumber = "ABC123";
        string departureAirport = "JFK International Airport";
        string scheduledTime = "08:30 AM";
        Console.WriteLine($"\nFlight {flightNumber} departing from {departureAirport} is scheduled for {scheduledTime}.");

        // Part 6: Personalized greeting
        Console.Write("\nEnter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nHello, {userName}! Welcome to our messaging app.");

        // Part 7: Custom badge for fantasy event
        Console.Write("\nEnter your character's name: ");
        string characterName = Console.ReadLine();
        Console.Write("Enter your character's class: ");
        string characterClass = Console.ReadLine();
        Console.WriteLine($"\nCustom Badge: {characterName} the {characterClass}");

        // Part 8: Song duration
        Console.Write("\nEnter the song's duration in seconds: ");
        int songDuration = int.Parse(Console.ReadLine());
        int minutes = songDuration / 60;
        int seconds = songDuration % 60;
        Console.WriteLine($"\nSong Duration: {minutes} minutes {seconds} seconds");

        // Part 9: Recipe serving size
        Console.Write("\nEnter the number of servings: ");
        int servings = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nServing Size: {servings,5}");

        // Part 10: Account balance
        Console.Write("\nEnter the account balance: ");
        double balance = double.Parse(Console.ReadLine());
        Console.WriteLine($"\nAccount Balance: {balance,10:F2}");

        // Part 11: Ticket price with discount
        Console.Write("\nEnter the ticket price: ");
        double ticketPrice = double.Parse(Console.ReadLine());
        Console.Write("Enter the discount percentage: ");
        double discount = double.Parse(Console.ReadLine());
        double discountedPrice = ticketPrice - (ticketPrice * discount / 100);
        Console.WriteLine($"\nDiscounted Price: {discountedPrice,10:F2}");

        // Part 12: Player's score
        Console.Write("\nEnter the player's score: ");
        int playerScore = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nPlayer's Score: {playerScore,8}");

        // Part 13: Average value of dataset
        Console.Write("\nEnter a series of numbers separated by spaces: ");
        double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double average = numbers.Average();
        Console.WriteLine($"\nAverage Value: {average,10:F2}");

        // Part 14: Average temperature
        Console.Write("\nEnter temperatures for 3 days separated by spaces: ");
        double[] temps = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
        double avgTemp = temps.Average();
        Console.WriteLine($"\nAverage Temperature: {avgTemp,10:F1}");

        // Part 15: Step count
        Console.Write("\nEnter the steps taken: ");
        int steps = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nStep Count: {steps,6}");
    }
}
