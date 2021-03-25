using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class UploadArchivesSettingsRepository : IUploadArchivesSettingsRepository
    {
        private readonly DataContext _context;
        public UploadArchivesSettingsRepository(DataContext context)
        {
            _context = context;
        }

        public UploadArchivesSettings Get() => _context.UploadArchivesSettings.FirstOrDefault();

        public void Set(UploadArchivesSettings uploadArchivesSettings)
        {
            var trxEntity = Get();
            if (trxEntity == null)
                Insert(uploadArchivesSettings);
            else
                Update(uploadArchivesSettings);
        }

        private void Insert(UploadArchivesSettings uploadArchivesSettings)
        {
            _context.UploadArchivesSettings.Add(uploadArchivesSettings);

            _context.SaveChanges();
        }

        private void Update(UploadArchivesSettings uploadArchivesSettings)
        {
            var trxEntity = Get();
            _context.Entry(trxEntity).CurrentValues.SetValues(uploadArchivesSettings);
            _context.SaveChanges();
        }
    }
}
