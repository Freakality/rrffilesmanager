using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class Pharmacy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public virtual Province Province { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public override string ToString() => Name;
    }
}
