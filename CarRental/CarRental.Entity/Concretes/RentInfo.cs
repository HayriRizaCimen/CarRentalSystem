using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entity.Concretes
{
    public class RentInfo
    {
        public int RentID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RentDateStart { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RentDateEnd { get; set; }

        [Required(ErrorMessage = "You must enter first km of car.")]
        public int FirstKM { get; set; }

        [Required(ErrorMessage = "You must enter last km of car.")]
        public int LastKM { get; set; }

        
        public int TotalRentalFee { get; set; }


        public int CarID { get; set; }
        public Car Car { get; set; }


        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}
