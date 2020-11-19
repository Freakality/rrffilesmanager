﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions
{
    public class Company
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public virtual Province Province { get; set; }
        public string PostalCode { get; set; }
        public override string ToString() => Description;
    }
}
