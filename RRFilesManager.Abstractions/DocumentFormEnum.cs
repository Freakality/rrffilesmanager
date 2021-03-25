using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public enum DocumentFormEnum
    {
        AdditionalInformation,
        StandardBenefitsStatement,
        SenderRecipient,
        BenefitType,
        PreparedBy,
        MedicalRecord,
        MedicalRecordWithAmount,
        BenefitsPaidToDate,
        NameOfParty,
        Name,
        NameAndTypeOfParty,
        NameAndTypeOfPartyAndTypeOfMotion,
        NameOfOrganization,
        Empty
    }
}
