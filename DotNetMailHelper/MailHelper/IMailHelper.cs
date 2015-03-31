namespace MailHelper
{
    public interface IMailHelper : IBaseHelper
    {
        void AddTo(string emailAdress, string displayName);
        void AddCc(string emailAdress, string displayName);
        void AddBcc(string emailAdress, string displayName);
        void Send();
    }
}