using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseImplement
{
    public class HardwareStorageDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q2JQENQ\SQLEXPRESS;
                Initial Catalog=HardwareStorageDatabase;
                Integrated Security=True;
                MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Category> Categorys { set; get; }
        public virtual DbSet<Technic> Technics { set; get; }
        public virtual DbSet<MovementType> MovementTypes { set; get; }
        public virtual DbSet<Counterparty> Counterpartys { set; get; }
        public virtual DbSet<Movement> Movements { set; get; }
        public virtual DbSet<Content> Contents { set; get; }
    }
}
