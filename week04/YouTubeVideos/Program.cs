using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> video1Comments = new List<Comment>();
        for (int i = 0; i < 5; i++)
        {
            string userName = $"User {i}";
            Comment comment = new Comment(userName, $"This is a sample comment by user {i}.");
            video1Comments.Add(comment);
        }

        Video video1 = new Video("Video 1", "Author 1", 300, video1Comments);
        Console.WriteLine("———————————————————————————————————————————————————————————————————————————");
        Console.WriteLine($"Title: {video1.GetTitle()}");
        Console.WriteLine($"Author: {video1.GetAuthor()}");
        Console.WriteLine($"Duration: {video1.GetVideoLengthSeconds()} seconds");
        Console.WriteLine();
        foreach (Comment comment in video1Comments)
        {
            Console.WriteLine($"User: {comment.GetAuthor()}");
            Console.WriteLine($"Comment: {comment.GetComment()}");
            Console.WriteLine();
        }
        Console.WriteLine("---------------------------------------------------------------------------");


        List<Comment> video2Comments = new List<Comment>();
        for (int i = 0; i < 5; i++)
        {
            string userName = $"User {i}";
            Comment comment = new Comment(userName, $"This is a sample comment by user {i}.");
            video2Comments.Add(comment);
        }

        Video video2 = new Video("Video 2", "Author 2", 900, video2Comments);
        Console.WriteLine("———————————————————————————————————————————————————————————————————————————");
        Console.WriteLine($"Title: {video2.GetTitle()}");
        Console.WriteLine($"Author: {video2.GetAuthor()}");
        Console.WriteLine($"Duration: {video2.GetVideoLengthSeconds()} seconds");
        Console.WriteLine();
        foreach (Comment comment in video2Comments)
        {
            Console.WriteLine($"User: {comment.GetAuthor()}");
            Console.WriteLine($"Comment: {comment.GetComment()}");
            Console.WriteLine();
        }
        Console.WriteLine("---------------------------------------------------------------------------");


        List<Comment> video3Comments = new List<Comment>();
        for (int i = 0; i < 5; i++)
        {
            string userName = $"User {i}";
            Comment comment = new Comment(userName, $"This is a sample comment by user {i}.");
            video3Comments.Add(comment);
        }

        Video video3 = new Video("Video 3", "Author 3", 1200, video3Comments);
        Console.WriteLine("———————————————————————————————————————————————————————————————————————————");
        Console.WriteLine($"Title: {video3.GetTitle()}");
        Console.WriteLine($"Author: {video3.GetAuthor()}");
        Console.WriteLine($"Duration: {video3.GetVideoLengthSeconds()} seconds");
        Console.WriteLine();
        foreach (Comment comment in video3Comments)
        {
            Console.WriteLine($"User: {comment.GetAuthor()}");
            Console.WriteLine($"Comment: {comment.GetComment()}");
            Console.WriteLine();
        }
    }
}