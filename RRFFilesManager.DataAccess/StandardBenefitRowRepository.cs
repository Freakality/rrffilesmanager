using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class StandardBenefitRowRepository : IStandardBenefitRowRepository
    {
        private readonly DataContext _context;
        public StandardBenefitRowRepository(DataContext context)
        {
            _context = context;
        }

        public StandardBenefitRow GetById(int rowId)
        {
            var account = _context.StandardBenefitRows.FirstOrDefault(x => x.ID == rowId);
            return account;
        }

        public void Insert(Archive archive, StandardBenefitRow standardBenefitRow)
        {
            standardBenefitRow.Archive = archive;
            _context.StandardBenefitRows.Add(standardBenefitRow);
            _context.SaveChanges();
        }

        public IEnumerable<StandardBenefitRow> List(int? archiveID = null)
        {
            var query = _context.StandardBenefitRows.AsQueryable();
            if (archiveID != null)
                query = query.Where(s => s.Archive.ID == archiveID.Value);
            return query.ToList();
        }

        public void SoftDelete(int rowId)
        {
            var accountToDelete = GetById(rowId);
            _context.SaveChanges();
        }
        public void DeleteArchiveRows(Archive archive)
        {
            var rowsToDelete = List(archive.ID);
            foreach (StandardBenefitRow row in rowsToDelete)
            {
                Delete(row);
            }
        }
        public void Delete(StandardBenefitRow standardBenefitRow)
        {
            var trxRow = GetById(standardBenefitRow.ID);
            /*int rowNumberDelete = trxRow.RowNumber;
            var rowlist = List(trxRow.ArchiveId);
            foreach (StandardBenefitRow row in rowlist)
            {
                if (row.RowNumber > rowNumberDelete)
                {
                    row.RowNumber--;
                    Update(row);
                }
            }*/
            _context.StandardBenefitRows.Remove(trxRow);
            _context.SaveChanges();
        }

        public void Update(StandardBenefitRow standardBenefitRow)
        {
            var trxRow = GetById(standardBenefitRow.ID);
            _context.Entry(trxRow).CurrentValues.SetValues(standardBenefitRow);
            _context.SaveChanges();
        }

    }
}
