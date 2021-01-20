using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entity
{
    public class RentInfo
    {
        public int RentID { get; set; }
        public DateTime RentDateStart { get; set; }
        public DateTime RentDateEnd { get; set; }
        public int FirstKM { get; set; }
        public int LastKM { get; set; }
        public int TotalRentalFee { get; set; }


        public int CarID { get; set; }
        public Car Car { get; set; }


        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}
