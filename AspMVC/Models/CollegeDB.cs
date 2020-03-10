using System.Data.Entity;

namespace AspMVC.Models
{
    public class CollegeDB : DbContext
    {
        public DbSet<QL_College> Colleges { get; set; }
    }
}