using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.AbstractLayer;
using DataAccessLayer.Entities.Abstract;

namespace DataAccessLayer.Entities
{
    public class Comment : BaseEntity<int>
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }

        public Comment() { }
        /// <summary>
        /// Constructor for Insert method with a new entity
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="body"></param>
        public Comment(int postId, string name, string email, string body)
        {
            PostID = postId;
            Name = name;
            Email = email;
            Body = body;
        }
        /// <summary>
        /// Constructor for loading existing entity from database
        /// </summary>
        /// <param name="commentID"></param>
        /// <param name="postId"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="body"></param>
        public Comment(int commentID,int postId, string name, string email, string body)
        {
            ID = commentID;
            PostID = postId;
            Name = name;
            Email = email;
            Body = body;
        }

        public void ChangeComment(string text)
        {
            Body = text;
        }
    }
}
