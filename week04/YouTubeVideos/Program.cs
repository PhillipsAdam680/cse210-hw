using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C#", "Programming with Adam", 600);

        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Sarah", "Very helpful."));
        video1.AddComment(new Comment("Mike", "Thanks for sharing!"));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Minecraft Survival Tips", "BlockMaster", 900);

        video2.AddComment(new Comment("Alex", "I learned something new."));
        video2.AddComment(new Comment("Emma", "Awesome video!"));
        video2.AddComment(new Comment("Chris", "Can't wait for Part 2."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Top 10 LEGO Sets", "Brick Builder", 720);

        video3.AddComment(new Comment("Ben", "I own number one!"));
        video3.AddComment(new Comment("Lucy", "Great ranking."));
        video3.AddComment(new Comment("James", "Now I want more LEGO."));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}