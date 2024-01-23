using GidGroup.Application.Abstractions;
using GidGroup.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.Security.Cryptography;

namespace GidGroup.Infrastructure.Persistance;

public class ApplicationDbContext : DbContext, IGidGroupApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
      //  Database.Migrate();
       // var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
    //    try
    //    {
    //        if (databaseCreator is null)
    //        {
    //            throw new Exception("Database Not Found!");
    //        }

    //        if (!databaseCreator.CanConnect())
    //            databaseCreator.CreateAsync();

    //        if (!databaseCreator.HasTables())
    //            databaseCreator.CreateTablesAsync();

    //}
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    }
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //}

    public DbSet<Order> Orders { get; set; }
    public DbSet<Recall> Recalls { get; set; }
    public DbSet<GetCatalog> GetCatalogs { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }
}
