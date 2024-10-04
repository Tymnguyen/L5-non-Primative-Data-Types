using System;

class Program
{
    static void Main(string[] args)
    {
        // Question 6: Accessing Enum Data for Weekday
        Console.WriteLine("Days of the week:");
        foreach (string day in Enum.GetNames(typeof(Weekday)))
        {
            Console.WriteLine(day);
        }

        // Example of using an enum value directly
        Weekday today = Weekday.Monday;
        Console.WriteLine($"\nToday is: {today}");

        // Accessing and displaying other enums
        EnemyState enemyState = EnemyState.Patrol;
        Console.WriteLine($"\nEnemy state is: {enemyState}");

        FlightStatus flightStatus = FlightStatus.Ascending;
        Console.WriteLine($"Flight status is: {flightStatus}");

        TitleRank playerRank = TitleRank.Intermediate;
        Console.WriteLine($"Player rank is: {playerRank}");

        PlayerMovement playerMovement = PlayerMovement.Run;
        Console.WriteLine($"Player is currently: {playerMovement}");
    }
}

//---------------------------------------------------------------------
// Question 1: Weekday Enumeration
public enum Weekday
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

//---------------------------------------------------------------------
// Question 2: Enemy State Enumeration
public enum EnemyState
{
    Idle,
    Patrol,
    Attack
}

//---------------------------------------------------------------------
// Question 3: Flight Status Enumeration
public enum FlightStatus
{
    Ascending,
    Descending,
    Stationary
}

//---------------------------------------------------------------------
// Question 4: Title Rank Enumeration
public enum TitleRank
{
    Beginner,
    Intermediate,
    Advanced
}

//---------------------------------------------------------------------
// Question 5: Player Movement Enumeration
public enum PlayerMovement
{
    Idle,
    Walk,
    Run
}
