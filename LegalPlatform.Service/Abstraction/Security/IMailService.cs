namespace GraduationProjectStore.Service.Abstraction.Security
{
    public interface IMailService
    {
        ValueTask<string> SendMail(string email,string subject,string message);
    }
}
