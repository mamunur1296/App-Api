﻿using App.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; } = null;
        public string Phone { get; set; }
    }
}
