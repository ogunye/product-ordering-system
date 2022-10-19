﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
