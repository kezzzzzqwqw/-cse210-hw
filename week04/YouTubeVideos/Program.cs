using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("C# Basics Tutorial", "John Doe", 330);
        Comment comment1 = new Comment("Alice", "Great Tutorial!");
        Comment comment2 = new Comment("Bob", "Very helpful, thanks!" );
        Comment comment3 = new Comment("Charlie", "I learned a lot.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video1.DisplayInfo();


    }
}