﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions
{
    public class DisabilityInsuranceCompany
    {
        public int ID { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}