using System;

namespace RRFFilesManager.Abstractions
{
    public class Contact
    {
        public int ID { get; set; }

        public virtual Group Group { get; set; }

        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Email { get; set; }
        public virtual Company Company { get; set; }

        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Cell { get; set; }
        public string DirectNumber { get; set; }
        public string DirectExtension { get; set; }
        public string OfficeNumber { get; set; }
        public string OfficeExtension { get; set; }
        public string Fax { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public virtual Province Province { get; set; }
        public string PostalCode { get; set; }
        public string MobileNumber { get; set; }
        public string MobileCarrier { get; set; }
        public string EmailToText { get; set; }

        public byte[] Photo { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string HealthCard { get; set; }
        public string SIN { get; set; }
        public string FirstLenguage { get; set; }

        public string Notes { get; set; }






        public string Website { get; set; }
        public string Relationship { get; set; }

        public override string ToString() =>  $"{FirstName} {LastName}";
    }
}
