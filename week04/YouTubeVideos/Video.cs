using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLengthSeconds;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int videoLengthSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _videoLengthSeconds = videoLengthSeconds;
        _comments = comments;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetVideoLengthSeconds()
    {
        return _videoLengthSeconds;
    }
}