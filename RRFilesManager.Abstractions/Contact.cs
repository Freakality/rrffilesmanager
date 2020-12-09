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
        public Company Company { get; set; }
        public string Memo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Province Province { get; set; }
        public string PostalCode { get; set; }

        public override string ToString() =>  $"{FirstName} {LastName}";
    }
}
