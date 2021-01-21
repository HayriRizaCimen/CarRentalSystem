using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entity.Concretes
{
    //[Table("Cars")]
    public class Car
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarID { get; set; }

        [Required(ErrorMessage = "You must enter a car name.")]
        public string CarName { get; set; }

        [Required(ErrorMessage = "You must enter a car model.")]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "You must enter a rent fee.")]
        public int RentFeeDaily { get; set; }

        [Required(ErrorMessage = "You must enter a total car km.")]
        public int CarTotalKM{ get; set; }

        [Required(ErrorMessage = "You must enter seats.")]
        public int CarTotalSeats { get; set; }

       
        public int isRent { get; set; }

        public int CompanyID { get; set; }
        public Company Company { get; set; }
    }
}
