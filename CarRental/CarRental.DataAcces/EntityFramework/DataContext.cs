using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAcces.EntityFramework
{
    public class DataContext:DbContext
    {
        public DbSet<Car> car { get; set; }

    }
}
