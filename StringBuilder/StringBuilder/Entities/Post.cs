using System;
using System.Collections.Generic;
using System.Text;

namespace Resolvido_2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComments (Comment comment)
        {
            Comment.Add(comment);

        }
        public void RemoveComment (Comment comment)
        {

            Comment.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Comments: ");
            foreach (var item in Comment)
            {
                sb.AppendLine(item.Text);
            }

            return sb.ToString();

        }
    }
}
