using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Store : BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public bool Status {  get; set; }
        public DateTime? TimeActive { get; set; }
        public int? UserId { get; set; }
        //R
        public virtual IEnumerable<Court>? Court { get; set; }
        public virtual User? User { get; set; }



    }
}
