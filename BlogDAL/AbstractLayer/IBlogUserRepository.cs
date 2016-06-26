using DataAccessLayer.Entities;

namespace DataAccessLayer.AbstractLayer
{
    interface IBlogUserRepository : IDataAccesRepository<int, BlogUser>
    {
        BlogUser GetByLoginPassword(string login, string password);
    }
}
