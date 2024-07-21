using System.Reflection.Metadata.Ecma335;

public class Video(string title, string author, int length)
{
    private string _title = title;
    private string _author = author;
    private int _length = length;

    private List<Comment> _comments = [];

    private int GetCommentsCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"\n{_title} | {_author} | {_length} seconds");
        Console.WriteLine($"Comments ({GetCommentsCount()}):");

        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"  - {comment.GetAuthorName()}: {comment.GetText()}");
        }
    }
}