using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.AbstractLayer;
using DataAccessLayer.Entities.Abstract;

namespace DataAccessLayer.Entities
{
    public class Administrator : BaseEntity<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Administrator(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public Administrator(int id, string name, string password)
        {
            ID = id;
            Name = name;
            Password = password;
        }
        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}
