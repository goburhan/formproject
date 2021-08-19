using FormProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        
        public DbSet<Person> Persons { get; set; }

       
    }
}
 