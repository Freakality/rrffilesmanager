using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class Company
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public virtual Province Province { get; set; }
        public string PostalCode { get; set; }
        public override string ToString() => Description;
    }
}
