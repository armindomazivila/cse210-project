using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Videos Project\n");

        // Create videos
        Video video1 = new Video("Learning C#", "Bro Code", 900);
        Video video2 = new Video("Object-Oriented Programming", "Programming with Mosh", 1200);
        Video video3 = new Video("Introduction to HTML", "freeCodeCamp", 1800);

        // Add comments to Video 1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("John", "Very easy to follow."));
        video1.AddComment(new Comment("Mary", "Thanks for sharing!"));

        // Add comments to Video 2
        video2.AddComment(new Comment("David", "Excellent explanation."));
        video2.AddComment(new Comment("Sarah", "This helped me a lot."));
        video2.AddComment(new Comment("Peter", "Keep making videos!"));

        // Add comments to Video 3
        video3.AddComment(new Comment("James", "Awesome content."));
        video3.AddComment(new Comment("Linda", "Very informative."));
        video3.AddComment(new Comment("Tom", "I learned something new today."));

        List<Video> videos = new List<Video>()
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}