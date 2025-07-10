class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\n\nVideo: {_title} by {_author}, duration of {_length} with {GetNumberOfComments()} comments.");
    }
    public void DisplayVideoComments()
    {
        Console.WriteLine("\nComments:\n");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
   
    }
}