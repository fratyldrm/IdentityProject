using IdentityProject.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebApi.Contexts;

public class MsSqlContext:DbContext

{
    public MsSqlContext(DbContextOptions opt) : base(opt)
    {

    }
  


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        // docker kurulu olanlar
            
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Identit_db;User=sa;Password=23768722984Ff.;TrustServerCertificate=true");

        // Localdb
        //optionsBuilder.UseSqlServer(@"Server= (localdb)\MSSQLLocalDB; Database=Identit_db; Trusted_Connection = true");
    
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

}
