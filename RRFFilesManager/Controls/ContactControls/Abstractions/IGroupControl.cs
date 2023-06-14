using RRFFilesManager.Abstractions;

namespace RRFFilesManager.Controls.ContactControls
{
    public interface IGroupControl
    {
        void SetContact(Contact client);
        void FillContact(Contact client);
        void SetGroup(Group group);
        void FillName(string firstName, string lastName);
    }
}