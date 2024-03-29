﻿using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ITemplateRepository
    {
        void Insert(Template template);
        void Update(Template template);
        void SoftDelete(int templateId);
        Template GetById(int templateId);
        ICollection<string> GetCategories();
        ICollection<string> GetTypesOfTemplate();
        IEnumerable<Template> List(int? matterTypeId = null, string category = null, string typeOfTemplate = null);
        IEnumerable<Template> Search(string searchText, MatterType matterType = null, string category = null, string typeOfTemplate = null, int? take = null);
    }
}
