using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> videoComments = new List<Comment>();
        for (int i = 0; i < 5; i++)
        {
            string userName = $"User {i}";
            Comment comment = new Comment(userName, $"This is a sample comment by user {i}.");
            videoComments.Add(comment);
        }

        Video video1 = new Video("Video 1", "Author 1", 300, videoComments);
        Video video2 = new Video("Video 2", "Author 2", 900, videoComments);
        Video video3 = new Video("Video 3", "Author 3", 1200, videoComments);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            List<Comment> comments = video.GetComments();
            Console.WriteLine("———————————————————————————————————————————————————————————————————————————");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetVideoLengthSeconds()} seconds");
            Console.WriteLine($"Comments: {video.NumberOfComments}");
            Console.WriteLine();
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"User: {comment.GetAuthor()}");
                Console.WriteLine($"Comment: {comment.GetComment()}");
                Console.WriteLine();
            }
        }
    }
}