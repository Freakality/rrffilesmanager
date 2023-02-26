using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class ABOverviewRepository : IABOverviewRepository
    {
        private readonly DataContext _context;
        public ABOverviewRepository(DataContext context)
        {
            _context = context;
        }

        public ABOverview GetById(int abOverviewId)
        {
            var account = _context.ABOverviews.FirstOrDefault(x => x.ID == abOverviewId);
            return account;
        }

        public void Insert(ABOverview abOverview, File file)
        {
            abOverview.File = file;
            _context.ABOverviews.Add(abOverview);
            _context.SaveChanges();
        }

        public IEnumerable<ABOverview> List()
        {
            return _context.ABOverviews.ToList(); ;
        }

        public void SoftDelete(int abOverviewId)
        {
            var accountToDelete = GetById(abOverviewId);
            _context.SaveChanges();
        }

        public void Update(ABOverview abOverview)
        {
            var trxFile = GetById(abOverview.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(abOverview) ;
            _context.SaveChanges();
        }

        public IEnumerable<ABOverview> Search(File file, int? take = null)
        {
            var query = _context.ABOverviews.Where(s =>
                s.File.ID == file.ID 
            );
            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
