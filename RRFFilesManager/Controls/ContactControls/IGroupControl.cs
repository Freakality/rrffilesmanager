using RRFFilesManager.Abstractions;

namespace RRFFilesManager.Controls.ContactControls
{
    public interface IGroupControl
    {
        void FillForm(Contact client);
        void FillContact(Contact client);
        void SetGroup(Group group);
    }
}