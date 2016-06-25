using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DataAccessLayer.AbstractLayer
{
    interface IAuthorizationRepository
    {
        BlogUser Login(string login, string password);
        BlogUser Register(BlogUser user);
    }
}
