using DataAccessLayer.Entities.Abstract;

namespace DataAccessLayer.Entities
{
    public class PostTag : BaseEntity<int>
    {
        public int ID { get; set; }
        public int TagID { get; set; }
    }
}
