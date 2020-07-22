﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace patient.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string IIN { get; set; }
        public string FIO { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}