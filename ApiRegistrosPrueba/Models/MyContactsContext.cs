using Microsoft.EntityFrameworkCore;

namespace ApiRegistrosPrueba.Models
{
    public class MyContactsContext : DbContext
    {
        public MyContactsContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<MyContacts> MyContactSet {get; set;}
    }
}