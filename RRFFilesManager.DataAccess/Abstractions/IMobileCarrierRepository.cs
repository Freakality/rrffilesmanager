using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IMobileCarrierRepository
    {
        void Insert(MobileCarrier mobileCarrier);
        void Update(MobileCarrier mobileCarrier);
        void SoftDelete(int mobileCarrierId);
        MobileCarrier GetById(int mobileCarrierId);
        IEnumerable<MobileCarrier> List();
    }
}
