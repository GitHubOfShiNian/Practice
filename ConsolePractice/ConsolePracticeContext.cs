using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace ConsolePractice
{
    public class ConsolePracticeContext : DbContext
    {
        public ConsolePracticeContext() : base("ConsolePracticeEntities")
        {
            this.Configuration.ProxyCreationEnabled = true;
            var aaa = new DbMigrationsConfiguration();//设置自动迁移属性
            aaa.AutomaticMigrationsEnabled = true;
        }
        public virtual DbSet<Company> Company { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            base.OnModelCreating(modelBuilder);
        }
    }
}
