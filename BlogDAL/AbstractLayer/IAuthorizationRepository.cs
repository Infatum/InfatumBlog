using DataAccessLayer.Entities;

namespace DataAccessLayer.AbstractLayer
{
    interface IAuthorizationRepository
    {
        BlogUser Login(string login, string password);
        BlogUser Register(BlogUser user);
    }
}
