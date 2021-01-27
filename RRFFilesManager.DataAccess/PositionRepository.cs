using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class PositionRepository : IPositionRepository
    {
        private readonly DataContext _context;
        public PositionRepository(DataContext context)
        {
            _context = context;
        }

        public  Position GetById(int positionId)
        {
            var position = _context.Positions.FirstOrDefault(x => x.ID == positionId);

            return position;

        }

        public void Insert(Position position)
        {
            _context.Positions.Add(position);

            _context.SaveChanges();
        }

        public  IEnumerable<Position> List(int? groupId = null)
        {
            var query = _context.Positions.AsQueryable();
            if (groupId != null)
                query = query.Where(s => s.Group.ID == groupId);
            return query.ToList(); ;
        }

        public void SoftDelete(int positionId)
        {
            var accountToDelete = _context.Positions.Find(positionId);

            _context.SaveChanges();

        }

        public void Update(Position position)
        {
            var trxPosition = GetById(position.ID);
            _context.Entry(trxPosition).CurrentValues.SetValues(position);
            _context.SaveChanges();

        }
    }
}
