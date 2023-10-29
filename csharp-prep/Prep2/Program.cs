using System;
/* Ask the user for their grade percentage, then write a series of if-elif-else 
statements to print out the appropriate letter grade. (At this point, 
you'll have a separate print statement for each grade letter in the appropriate block.)

Assume that you must have at least a 70 to pass the class. After determining the 
letter grade and printing it out. Add a separate if statement to determine if 
the user passed the course, and if so display a message to congratulate them. 
If not, display a different message to encourage them for next time.

Change your code from the first part, so that instead of printing the 
letter grade in the body of each if, elif, or else block, instead create 
a new variable called letter and then in each block, set this variable to 
the appropriate value. Finally, after the whole series of if-elif-else 
statements, have a single print statement that prints the letter grade once.
A >= 90
B >= 80
C >= 70
D >= 60
F < 60
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string userInput1 = Console.ReadLine();
        int numberGrade = int.Parse(userInput1);
        string letter;

        if (numberGrade >= 90)
        {
            letter ="A";
        }
        else if (numberGrade >= 80)
        {
            letter="B";
        }
        else if (numberGrade >= 70)
        {
            letter="C";
        }
        else if (numberGrade >= 60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }

        Console.WriteLine($"Your letter grade is {letter}");
        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("You didn't pass. Try harder next time.");
        }
    }
}