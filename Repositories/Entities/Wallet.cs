using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Wallet : BaseEntity
    {
        public DateTime? dateWallet { get; set; }
        public int? userID { get; set; }
        public virtual User User { get; set; }
    }
}
