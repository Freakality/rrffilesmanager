using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IPharmacyRepository
    {
        void Insert(Pharmacy pharmacy);
        void Update(Pharmacy pharmacy);
        void SoftDelete(int pharmacyId);
        Pharmacy GetById(int pharmacyId);
        IEnumerable<Pharmacy> List();
    }
}
