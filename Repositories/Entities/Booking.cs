using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Booking: BaseEntity
    {
        public string? BookingName { get; set; }
        public string? Decription { get; set; }
        public int? CheckingID { get; set; }
        public DateTime? BookingDate { get; set; }
        public bool StatusPayment { get; set; }
        public float? TotalPrice { get; set; }
        public int? UserID { get; set; }
 
        //R
        public virtual User? User { get; set; }
        public virtual DayBooking? DayBooking { get; set; }
        public virtual FixedBooking? FixedBooking { get; set; } 
        public virtual FlexBooking? FlexBooking { get; set; } = null;
        public virtual IEnumerable<Invoice>? Invoices { get; set; }
        public virtual Schedule? Schedule { get; set; } 

    }
}
