using System.Data.Entity;

namespace Carlos.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConecction")
        {

        }

        public System.Data.Entity.DbSet<Carlos.Models.Clown> Clowns { get; set; }
    }
}