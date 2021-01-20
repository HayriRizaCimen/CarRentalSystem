using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entity
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int TotalCars { get; set; }

        public List<Car> Cars { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
