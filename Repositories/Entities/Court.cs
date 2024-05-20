using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
   public class Court: BaseEntity
    {
        public string? Name { get; set; }
        public int? SlotID { get; set; }
        public bool StatusCourt { get; set; }


        //R
        public virtual Store? Store { get; set; }
        public virtual IEnumerable<Schedule>? Schedules { get; set; }

    }
}
