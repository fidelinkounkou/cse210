using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Basic C# Guide", "DevAcademy", 480);
        video1.AddComment(new Comment("John", "This was very helpful."));
        video1.AddComment(new Comment("Sarah", "Clear explanations, thanks!"));
        video1.AddComment(new Comment("Mike", "Can you cover encapsulation next?"));
        videos.Add(video1);

        Video video2 = new Video("Cooking 101", "ChefMaster", 600);
        video2.AddComment(new Comment("Emma", "Tried this recipe today."));
        video2.AddComment(new Comment("Liam", "Amazing tips for beginners."));
        video2.AddComment(new Comment("Olivia", "Subscribed to your channel."));
        videos.Add(video2);

        Video video3 = new Video("Cardio Workout", "FitnessZone", 900);
        video3.AddComment(new Comment("Lucas", "Hard but rewarding."));
        video3.AddComment(new Comment("Sophia", "Perfect morning routine."));
        video3.AddComment(new Comment("James", "My legs are burning!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Comments Count: " + video.GetCommentCount());
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("- " + comment.GetName() + ": " + comment.GetText());
            }
        }
    }
}
