using System;
using DataAccessLayer.Entities.Abstract;

namespace DataAccessLayer.Entities
{
    public class BlogPost : BaseEntity<int>
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        public string Body { get; set; }

        public BlogPost(string title, DateTime date, string body)
        {
            Title = title;
            PostDate = date;
            Body = body;
        }

        public BlogPost(int id, string title, DateTime date, string body)
        {
            ID = id;
            Title = title;
            PostDate = date;
            Body = body;
        }

        public void ChangePostBody(string text)
        {
            Body = text;
        }

        public void ChangeTitle(string title)
        {
            Title = title;
        }

        public void DateModify(DateTime newDate)
        {
            PostDate = newDate;
        }
    }
}
