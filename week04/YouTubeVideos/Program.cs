using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Classes Explained", "Code Master", 850);
        video1.AddComment(new Comment("Alice", "Very informative!"));
        video1.AddComment(new Comment("Ben", "Helped me understand abstraction."));
        video1.AddComment(new Comment("Clara", "Thanks!"));

        Video video2 = new Video("Visual Studio Code Tips", "Tech Hub", 640);
        video2.AddComment(new Comment("David", "These shortcuts are awesome."));
        video2.AddComment(new Comment("Emma", "Exactly what I needed."));
        video2.AddComment(new Comment("Frank", "Great video!"));

        Video video3 = new Video("Learn Git in 15 Minutes", "Programming Today", 900);
        video3.AddComment(new Comment("Grace", "Git finally makes sense."));
        video3.AddComment(new Comment("Henry", "Very clear explanation."));
        video3.AddComment(new Comment("Isaac", "Subscribed!"));

        Video video4 = new Video("Object-Oriented Programming Basics", "CS Tutorials", 1200);
        video4.AddComment(new Comment("Jack", "Excellent examples."));
        video4.AddComment(new Comment("Kelly", "Loved this lesson."));
        video4.AddComment(new Comment("Leo", "Can't wait for the next one."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}