using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("C# Basics", "John Doe", 330);
        Video video2 = new Video("OOP in C#", "Jane Smith", 480);
        Video video3 = new Video("Advanced C# Concepts", "Alex Johnson", 600);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I finally understand this."));
        
        video2.AddComment(new Comment("David", "OOP is much clearer now."));
        video2.AddComment(new Comment("Emma", "Nice examples!"));
        video2.AddComment(new Comment("Frank", "This helped my assignment."));
        
        video3.AddComment(new Comment("Grace", "Advanced but well explained."));
        video3.AddComment(new Comment("Hannah", "I need to rewatch this."));
        video3.AddComment(new Comment("Ian", "Great depth of content."));
        video3.AddComment(new Comment("Jack", "Subscribed!"));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }


}