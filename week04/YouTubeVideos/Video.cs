using System;
using System.Collections.Generic;

public abstract class VideoBase
{
    public abstract string GetVideoInfo();
    public abstract void AddComment(string name, string text);
    public abstract string GetComments();
}

public class Video : VideoBase
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public override string GetVideoInfo()
    {
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of comments: {Comments.Count}";
    }

    public override void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public override string GetComments()
    {
        string comments = "";
        foreach (var comment in Comments)
        {
            comments += $" {comment.Name}: {comment.Text}\n";
        }
        return comments;
    }
}

