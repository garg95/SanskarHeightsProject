using System.Data.Entity;


namespace DataLayers
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Models.Employee> employees { get; set; }
    }
}
