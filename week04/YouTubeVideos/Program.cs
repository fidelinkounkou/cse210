using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Tutorial", "TechAcademy", 720);
        v1.AddComment(new Comment("Alice", "Great abstraction explanation!"));
        v1.AddComment(new Comment("Bob", "Clear and easy."));
        v1.AddComment(new Comment("Charlie", "Thanks!"));
        videos.Add(v1);

        Video v2 = new Video("Yoga Basics", "HealthyLife", 600);
        v2.AddComment(new Comment("David", "Relaxing!"));
        v2.AddComment(new Comment("Emma", "Perfect routine."));
        v2.AddComment(new Comment("Frank", "Awesome video."));
        videos.Add(v2);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title} | Author: {video.Author} | {video.Length}s");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");
            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"- {c.Name}: \"{c.Text}\"");
            }
            Console.WriteLine();
        }
    }
}
