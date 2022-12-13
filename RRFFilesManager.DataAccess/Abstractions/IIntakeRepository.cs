using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IIntakeRepository
    {
        void Insert(Intake intake, File file);
        void Update(Intake intake);
        void SoftDelete(int intakeId);
        Intake GetById(int intakeId);
        IEnumerable<Intake> List();
        IEnumerable<Intake> Search(string searchText, bool? hold = null, int? take = null);
        IEnumerable<object> Search2();
    }
}
