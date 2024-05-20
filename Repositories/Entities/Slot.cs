using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Slot: BaseEntity
    {
        public string? Name { get; set; }
        public DateTime StartHours { get; set; }
        public DateTime EndHours { get; set; }

        //R
        public virtual Schedule? Schedule { get; set; }


    }
}
