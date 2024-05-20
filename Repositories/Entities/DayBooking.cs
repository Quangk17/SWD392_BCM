using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class DayBooking: BaseEntity
    {
        public bool IsActive {  get; set; }
        public DateTime StartDate { get; set; }
        public string? Name { get; set; }

        //R
        public virtual Booking? Booking { get; set; }
    }
}
