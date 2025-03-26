using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Videos Project\n");

        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this video."));

        Video video2 = new Video("Top 10 Programming Languages", "TechWorld", 900);
        video2.AddComment(new Comment("Dave", "Python is my favorite!"));
        video2.AddComment(new Comment("Eve", "Great insights, thanks for sharing."));
        video2.AddComment(new Comment("Frank", "I think JavaScript should be higher on the list."));

        Video video3 = new Video("How to Build a Website", "WebDevPro", 1200);
        video3.AddComment(new Comment("Grace", "This was super easy to follow."));
        video3.AddComment(new Comment("Hank", "Can you make a video on CSS next?"));
        video3.AddComment(new Comment("Ivy", "Loved the step-by-step explanation."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}