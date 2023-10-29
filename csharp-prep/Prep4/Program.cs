using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        string inputString = "999";
        Console.Clear();
        while (inputString!="0")
        {
            Console.Write("Please add a positive or negative integer to the list. (Enter 0 to end): ");
            inputString=Console.ReadLine();
            numbers.Add(int.Parse(inputString));
        }
        //Using .Sum, .Average, and .Max methods of List class
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The the largest number is: {numbers.Max()}");
        //Using .Min method of List class with LINQ lambda expression
        Console.WriteLine($"The smallest positive number is: {numbers.Where(i => i > 0).Min()}");
        Console.WriteLine("\nOriginal List:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\nSorted List:");
        //Sort ascending
        List<int> sortedNumbers = numbers.OrderBy(number => number).ToList();
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}