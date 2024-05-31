using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Cooking like a pro", "Isaac the cook", 300);
        video1.AddComment(new Comment("Baraza", "Great video!"));
        video1.AddComment(new Comment("John", "This sucks, Go to hell!"));
        video1.AddComment(new Comment("Brick", "I love it"));
        videos.Add(video1);

        Video video2 = new Video("Walking with your hands", "David Jones", 400);
        video2.AddComment(new Comment("Angom", "Get a life!"));
        video2.AddComment(new Comment("Brenda", "You need a job!"));
        videos.Add(video2);

        Video video3 = new Video("Drinking with your feet", "Agness", 1200);
        video3.AddComment(new Comment("Hilda", "This is cool."));
        video3.AddComment(new Comment("Herbert", "You are the best!"));
        video3.AddComment(new Comment("Olivia", "Two minutes of my life am never getting back."));
        video3.AddComment(new Comment("Jane", "I dont know."));
        videos.Add(video3);

       
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(); // New line for better readability
        }
    }
}

