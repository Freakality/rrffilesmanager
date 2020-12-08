using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IIntakeRepository
    {
        Task InsertAsync(Intake intake, File file);
        Task UpdateAsync(Intake intake);
        Task SoftDelteAsync(int intakeId);
        Task<Intake> GetByIdAsync(int intakeId);
        Task<IEnumerable<Intake>> ListAsync();
        Task<IEnumerable<Intake>> SearchAsync(string searchText, bool? hold = null, int? take = null);
    }
}
