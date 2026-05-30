using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "CodeAcademy", 900);
        video1.AddComment(new Comment("John Doe", "This explained abstraction perfectly!"));
        video1.AddComment(new Comment("Alice Smith", "Great video, very clear examples."));
        video1.AddComment(new Comment("Bob Jones", "Finally I understand classes in C#."));
        videosList.Add(video1);

        Video video2 = new Video("How to Bake the Perfect Sourdough Cake", "Chef Maria", 1200);
        video2.AddComment(new Comment("amazing R.", "My bread turned out amazing, thank you!"));
        video2.AddComment(new Comment("Lucia_2005", "What temperature should the oven be?"));
        video2.AddComment(new Comment("David Something.", "Loved the step-by-step breakdown."));
        videosList.Add(video2);

        Video video3 = new Video("SpaceX Mars Mission Updates", "SpaceNews", 650);
        video3.AddComment(new Comment("Elon X Fan", "This is the future of humanity!"));
        video3.AddComment(new Comment("Sarah W.", "The engineering behind this is insane!"));
        video3.AddComment(new Comment("Tommy90", "Can't wait to see the next launch."));
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("\nComments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: \"{comment.Text}\"");
            }
        }
        Console.WriteLine("-------------------------------------------------------------");
    }
}