using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IQuestionnaireFieldMapperRepository
    {
        void Insert(QuestionnaireFieldMapper entity);
        void Update(QuestionnaireFieldMapper entity);
        void SoftDelete(int entityId);
        void Delete(QuestionnaireFieldMapper entity);
        QuestionnaireFieldMapper GetById(int entityId);
        IEnumerable<QuestionnaireFieldMapper> List();
    }
}
