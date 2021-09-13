using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.FileControls.Models
{
    public class Prescription
    {
        private OutOfPocketHealthCareExp outOfPocketHealthCareExp;
        public Prescription(OutOfPocketHealthCareExp outOfPocketHealthCareExp)
        {
            ID = outOfPocketHealthCareExp.ID;
            Date = outOfPocketHealthCareExp.RxFillDate;
            ProviderName = outOfPocketHealthCareExp.Pharmacy;
            Drug = outOfPocketHealthCareExp.Drug;
            DispenseQuantity = outOfPocketHealthCareExp.DispenseQuantity;
            ReturnKilometresTraveled = Math.Round(outOfPocketHealthCareExp.ReturnKilometresTraveled ?? 0, 2);
            TravelExpenses = Math.Round(outOfPocketHealthCareExp.TravelExpenses ?? 0, 2);
            ParkingExpenses = Math.Round(outOfPocketHealthCareExp.ParkingExpenses ?? 0, 2);
            TreatmentExpenses = Math.Round(outOfPocketHealthCareExp.TreatmentExpenses ?? 0, 2);
            MiscExpenses = Math.Round(outOfPocketHealthCareExp.MiscExpenses ?? 0, 2);
            this.outOfPocketHealthCareExp = outOfPocketHealthCareExp;
        }
        public bool Check { get; set; }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Pharmacy ProviderName { get; set; }
        public Drug Drug { get; set; }
        public int DispenseQuantity { get; set; }
        public double? ReturnKilometresTraveled { get; set; }
        public double? TravelExpenses { get; set; }
        public double? ParkingExpenses { get; set; }
        public double? TreatmentExpenses { get; set; }
        public double? MiscExpenses { get; set; }

        public OutOfPocketHealthCareExp GetEntity() => this.outOfPocketHealthCareExp;

    }
}
