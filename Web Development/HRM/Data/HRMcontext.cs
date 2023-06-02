using Microsoft.EntityFrameworkCore;
namespace HRM.Data;
using HRM.Models;
public class Class1 : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=use1;Integrated Security=True;");
        }
    }
