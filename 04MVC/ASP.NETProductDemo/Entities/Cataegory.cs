﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cataegory
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SortCode { get; set; }
        public Cataegory()
        {
            this.ID = Guid.NewGuid();
        }
    }
}