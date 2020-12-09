using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IHearAboutUsRepository
    {
        void Insert(HearAboutUs hearAboutUs);
        void Update(HearAboutUs hearAboutUs);
        void SoftDelete(int hearAboutUsId);
        HearAboutUs GetById(int hearAboutUsId);
        IEnumerable<HearAboutUs> List();
    }
}
