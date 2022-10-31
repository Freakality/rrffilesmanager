using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data.Objects;
using System.Reflection;

namespace RRFFilesManager.DataAccess
{
    public class TimelineRepository : ITimelineRepository
    {
        private readonly DataContext _context;

        public TimelineRepository(DataContext context)
        {
            _context = context;
        }
        public void Insert(Timeline timeline, File file)
        {
            timeline.File = file;
            _context.Timelines.Add(timeline);
            _context.SaveChanges();
        }
        public void Update(Timeline timeline)
        {
            var trxFile = GetById(timeline.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(timeline);
            _context.SaveChanges();
        }
        public void SoftDelete(int timelineId)
        {
            var accountToDelete = GetById(timelineId);
            _context.SaveChanges();
        }
        public Timeline GetById(int timelineId)
        {
            var account = _context.Timelines.FirstOrDefault(x => x.ID == timelineId);
            return account;
        }
        public IEnumerable<Timeline> List()
        {
            return _context.Timelines.ToList(); ;
        }
        public IEnumerable<Timeline> Search(File file, int? take = null)
        {
            var query = _context.Timelines.Where(s =>
                s.File.ID == file.ID
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
