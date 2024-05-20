using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Schedule: BaseEntity
    {
        public float Price { get; set; }
        public bool Status { get; set; }  
        public DateTime Date { get; set; }

        //R
        public virtual Court? Court { get; set; }
        public virtual Booking? Booking { get; set; }
        public virtual Slot? Slot { get; set; } 

    }
}
