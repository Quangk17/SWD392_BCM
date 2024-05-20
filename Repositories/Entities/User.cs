using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? Hours { get; set; }
        public string? RoleID { get; set; }
        public string? Gender { get; set; }

        //R
        public virtual Role? Role { get; set; }
        public virtual Store? Store { get; set; }
        public virtual IEnumerable<Booking>? Bookings { get; set; }
        public virtual IEnumerable<CheckingStaff>? CheckingStaff { get; set; }

    }
}
