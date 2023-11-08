using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public class AppDbContext: DbContext
{
    public DbSet<ContactEntity> Contacts { get; set; }
    private string Path { get; set; }

    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        Path = System.IO.Path.Join(path, "contacts.db"); 
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data source={Path}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactEntity>().HasData
        (
            new ContactEntity() {ContactId = 1, Name="Adam", Email="adam@wsei.edu.pl", Phone="124124234", Birth=DateTime.Parse("2000-10-10")},
            new ContactEntity() {ContactId = 2, Name="Adam", Email="adam@wsei.edu.pl", Phone="124124234", Birth=DateTime.Parse("2000-10-10")},
            new ContactEntity() {ContactId = 3, Name="Adam", Email="adam@wsei.edu.pl", Phone="124124234", Birth=DateTime.Parse("2000-10-10")}
        );
    }
}
