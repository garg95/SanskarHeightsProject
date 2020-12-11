using Models;
using System.Data.Entity;


namespace DataLayers
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Standard> standards { get; set; }
    }
}
