using Microsoft.EntityFrameworkCore;
using Protofolio_Website.Db_Set;

namespace Login_and_Register_API.Database
{
    public class Db_Context : DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options) : base(options)
        {
            
        }
        public DbSet<Message> AddMessage { get; set; }
    }
}
