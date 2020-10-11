using System;

namespace RRFFilesManager.Abstractions
{
    public class Client
    {
        public string ID { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string SuiteApt { get; set; }
        public string Email { get; set; }
        public Province Province { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string MobileNumber { get; set; }
        public string MobileCarrier { get; set; }
        public string EmailToText { get; set; }
        public string OtherNotes { get; set; }
    }
}
