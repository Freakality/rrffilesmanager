using System;

namespace RRFFilesManager.Abstractions
{
    public class Contact
    {
        public int ID { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public virtual Company Company { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Cell { get; set; }
        public string Phone { get; set; }
        public string MobileNumber { get; set; }
        public string MobileCarrier { get; set; }
        public string EmailToText { get; set; }
        public string Notes { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public string DirectPhoneNumber { get; set; }
        public string DirectPhoneExtension { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string OfficePhoneExtension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public virtual Province Province { get; set; }
        public string PostalCode { get; set; }
        public string Website { get; set; }
        public string Relationship { get; set; }

        public override string ToString() =>  $"{FirstName} {LastName}";
    }
}
