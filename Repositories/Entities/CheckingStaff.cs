using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class CheckingStaff: BaseEntity
    {
        public bool StatusCheck {  get; set; }
        public virtual User? User { get; set; }
        public virtual Booking? Booking { get; set; }

        //R
        public virtual User? StaffID { get; set; }
        public virtual Booking? CheckingID { get; set; }

    }
}
