﻿using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IArchiveRepository
    {
        void Insert(File file, Archive archive);
        void Update(Archive archive);
        void SoftDelete(int archiveId);
        Archive GetById(int archiveId);
        IEnumerable<Archive> List();
    }
}