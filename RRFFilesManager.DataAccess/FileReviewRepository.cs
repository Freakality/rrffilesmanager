using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class FileReviewRepository : IFileReviewRepository
    {
        private readonly DataContext _context;
        public FileReviewRepository(DataContext context)
        {
            _context = context;
        }

        public FileReview GetById(int fileReviewId)
        {
            var account = _context.FileReviews.FirstOrDefault(x => x.ID == fileReviewId);
            return account;
        }

        public void Insert(FileReview fileReview, File file)
        {
            fileReview.File = file;
            _context.FileReviews.Add(fileReview);
            _context.SaveChanges();
        }

        public IEnumerable<FileReview> List()
        {
            return _context.FileReviews.ToList(); ;
        }

        public void SoftDelete(int fileReviewId)
        {
            var accountToDelete = GetById(fileReviewId);
            _context.SaveChanges();
        }

        public void Update(FileReview fileReview)
        {
            var trxFile = GetById(fileReview.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(fileReview);
            _context.SaveChanges();
        }

        public IEnumerable<FileReview> Search(File file, DateTime dateOfReview, Byte status, int? take = null)
        {
            var query = _context.FileReviews.Where(s =>
                s.File.ID == file.ID &&
                s.FRDate == dateOfReview &&
                s.FRActionABenefitsStatus == status
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
