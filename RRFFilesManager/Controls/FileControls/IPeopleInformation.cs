using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.FileControls
{
    public interface IPeopleInformation
    {
        void SetContact(Contact contact);
        void SetForm(Contact contact);
    }
}
