using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder_EnumsComposition.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> ListComments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
            ListComments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            ListComments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            ListComments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append(" likes - ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine(Content);
            stringBuilder.AppendLine("Comments:");
            foreach (Comment comment in ListComments)
            {
                stringBuilder.AppendLine(comment.Text);
            }
            return stringBuilder.ToString();
        }
    }
}
