using Microsoft.EntityFrameworkCore;

namespace Register.Models
{
    public class ConnectionStringClass : DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options) : base(options)
        {

        }
        public DbSet<EmpClass> Machines { get; set; }
    }
}
