﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact:BaseModel
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
