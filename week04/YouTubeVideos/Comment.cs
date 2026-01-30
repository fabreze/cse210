public class Comment
{
    private string _author;
    private string _commentText;

    public Comment(string author, string commentText)
    {
        _author = author;
        _commentText = commentText;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetComment(string commentText)
    {
        _commentText = commentText;
    }

    public string GetComment()
    {
        return _commentText;
    }
}