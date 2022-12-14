using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class OutOfPocketHealthCareExp
    {
        public int ID { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public virtual File File { get; set; }
        public virtual Archive Archive { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
        public DateTime RxFillDate { get; set; }
        public int DispenseQuantity { get; set; }
        public virtual Drug Drug { get; set; }
        public virtual double? ReturnKilometresTraveled { get; set; }
        public virtual double? TravelExpenses { get; set; }
        public virtual double? ParkingExpenses { get; set; }
        public virtual double? TreatmentExpenses { get; set; }
        public virtual double? MiscExpenses { get; set; }

        public override string ToString() => $"{File} - {Pharmacy} - {Drug}";
    }
}
