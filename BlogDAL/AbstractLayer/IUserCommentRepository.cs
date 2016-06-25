using System.Collections.Generic;
using DataAccessLayer.Entities;

namespace DataAccessLayer.AbstractLayer
{
    interface IUserCommentRepository : IDataAccesRepository<int, Comment>
    {
        IList<Comment> GetCommentsByUserID(int userID);
        int GetCountByUserID(int userID);
        IList<AuthorizedComment> GetAllWithUserNick();  
    }
}
