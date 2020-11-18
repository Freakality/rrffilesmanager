using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IIntakeRepository
    {
        Task InsertAsync(Intake intake);
        Task UpdateAsync(Intake intake);
        Task SoftDelteAsync(int intakeId);
        Task<Intake> GetByIdAsync(int intakeId);
        Task<IEnumerable<Intake>> ListAsync();
        Task<IEnumerable<Intake>> SearchAsync(string searchText);
    }
}
