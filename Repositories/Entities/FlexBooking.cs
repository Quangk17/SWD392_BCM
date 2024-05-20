using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class FlexBooking: BaseEntity
    {
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime Hours { get; set; }

        //R
        public virtual Booking? Booking { get; set; }
    }
}
