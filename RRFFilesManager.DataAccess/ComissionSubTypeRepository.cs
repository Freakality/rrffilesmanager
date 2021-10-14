using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class ComissionSubTypeRepository : GenericRepository<ComissionSubType>
    {
        public ComissionSubTypeRepository(DataContext context) : base(context, context.ComissionSubTypes)
        {
        }
    }
}
