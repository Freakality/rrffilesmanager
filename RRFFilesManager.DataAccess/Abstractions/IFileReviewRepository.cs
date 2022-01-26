using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IFileReviewRepository
    {
        void Insert(FileReview fileReview, File file);
        void Update(FileReview fileReview);
        void SoftDelete(int fileReviewId);
        FileReview GetById(int fileReviewId);
        IEnumerable<FileReview> List();
        IEnumerable<FileReview> Search(File file, DateTime dateOfReview, Byte status, int? take = null);
    }
}
