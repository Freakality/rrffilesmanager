using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IProvinceRepository
    {
        void Insert(Province province);
        void Update(Province province);
        void SoftDelete(int provinceId);
        Province GetById(int provinceId);
        IEnumerable<Province> List();
    }
}
