using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.AbstractLayer;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Entities
{
    public class BaseEntity  
    {
        private string _currentTableName = null;
        private dynamic _instance;
    }
}
