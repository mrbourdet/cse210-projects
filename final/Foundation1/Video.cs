using System;
using System.Collections.Generic;

class Video
{
    const string TabChar = "\t"; //PascalCase for constants or UPPERCASE?
    public string Title;
    public string Author;
    public int LengthInSeconds;
    private List<Comment> Comments = new List<Comment>();

    public void AddComment(string commenterName, string commentText)
    {
        Comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title:{TabChar}{Title}");
        Console.WriteLine($"Author:{TabChar}{Author}");
        Console.WriteLine($"Length:{TabChar}{LengthInSeconds} seconds");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Number of Comments:{TabChar}{GetNumberOfComments()}");
        Console.ResetColor();

        Console.WriteLine("\nComments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"{TabChar}{comment.CommenterName}: {comment.CommentText}");
        }

        Console.WriteLine();
    }
}