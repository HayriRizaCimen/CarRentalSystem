using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entity
{
    [Table("Cars")]
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public int RentFeeDaily { get; set; }
        public int CarTotalKM{ get; set; }
        public int CarTotalSeats { get; set; }
        public int isRent { get; set; }

        public int CompanyID { get; set; }
        //public Company Company { get; set; }
    }
}
