using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userNumberSquared = SquareNumber(userNumber);
        DisplayResult(userName, userNumberSquared);

    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please type your name: ");
        string userResponse = Console.ReadLine();
        return userResponse;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please type favorite number: ");
        string userResponse = Console.ReadLine();
        int favoriteNumber = int.Parse(userResponse);
        return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        int numberSquard = number*number;
        return numberSquard;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, your favorite number squared is: {squaredNumber}");
    }
}