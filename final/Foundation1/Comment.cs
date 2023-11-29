using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName;
    public string CommentText;


    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
    public string GetCommenterName ()
    {
        return CommenterName;
    }
    public string GetCommentText ()
    {
        return CommentText;
    }
}