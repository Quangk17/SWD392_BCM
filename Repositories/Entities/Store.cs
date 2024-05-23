﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Store : BaseEntity
    {
        public string? name { get; set; }
        public string? address { get; set; }
        public bool? status {  get; set; }
        public DateTime? timeActive { get; set; }
        public int? userId { get; set; }
        //R
        public virtual IEnumerable<Court> Courts { get; set; }
        public virtual User? User { get; set; }



    }
}
