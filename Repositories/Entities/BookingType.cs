using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class BookingType : BaseEntity
    {
        public string? name { get; set; }
        public virtual IEnumerable<Booking> Bookings { get; set;}
    }
}
