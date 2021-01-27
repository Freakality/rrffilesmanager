using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IPositionRepository
    {
        void Insert(Position position);
        void Update(Position position);
        void SoftDelete(int positionId);
        Position GetById(int positionId);
        IEnumerable<Position> List(int? groupId = null);
    }
}
