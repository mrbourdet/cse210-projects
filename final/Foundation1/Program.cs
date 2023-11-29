using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and populate videos
        AddVideos();

        // Display information for each video
        Console.Clear();
        Console.WriteLine("Foundation Program 1: Abstraction with YouTube Videos");
        Console.WriteLine("------------------------------------------------------------------");

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("------------------------------------------------------------------");
        }

        void AddVideos()
        {
            Video video1 = new Video
            {
                Title = "Introduction to C# Programming",
                Author = "A.Patagonicus",
                LengthInSeconds = 300
            };
            video1.AddComment("Emperor2349", "Great video! More fish!");
            video1.AddComment("HungryOrca", "Not very helpful.");
            video1.AddComment("WalRuzToof", "It wuz ok.");
            video1.AddComment("FurSealTeam6", "Arf! Arf! Slap! Slap! Well done old chap.");
            //------------------------------------------------------------------------
            Video video2 = new Video
            {
                Title = "Python Basics",
                Author = "Squamata",
                LengthInSeconds = 450
            };
            video2.AddComment("GorillaMyDreams", "Awesome explanation!");
            video2.AddComment("B.Constrictor", "Thanks. Can you make a tutorial on swallowing large prey?");
            video2.AddComment("PyRana", "Keep up the good work!");
            //------------------------------------------------------------------------
            Video video3 = new Video
            {
                Title = "Using an Arduino and Python",
                Author = "MaganellicP",
                LengthInSeconds = 600
            };
            video3.AddComment("Chinstrap1", "Fascinating topic!");
            video3.AddComment("BrownFuzzyKingBaby", "I'm interested in more examples.");
            video3.AddComment("AdélieP24", "This helped me a lot.");
            //------------------------------------------------------------------------
            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);
        }
    }
}