using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface ILawyerRepository
    {
        Task InsertAsync(Lawyer lawyer);
        Task UpdateAsync(Lawyer lawyer);
        Task SoftDelteAsync(int lawyerId);
        Task<Lawyer> GetByIdAsync(int lawyerId);
        Task<IEnumerable<Lawyer>> ListAsync();
    }
}
