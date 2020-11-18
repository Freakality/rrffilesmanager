using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IHearAboutUsRepository
    {
        Task InsertAsync(HearAboutUs hearAboutUs);
        Task UpdateAsync(HearAboutUs hearAboutUs);
        Task SoftDelteAsync(int hearAboutUsId);
        Task<HearAboutUs> GetByIdAsync(int hearAboutUsId);
        Task<IEnumerable<HearAboutUs>> ListAsync();
    }
}
