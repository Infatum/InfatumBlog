using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Abstract
{
    public class BaseEntity<TKey>
    {
        public TKey ID { get; set; }
    }
}
