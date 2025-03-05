namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication
{
    public class ConfirmForgotPasswordDTO
    {
        public string UserName { set; get; }
        public string ConfirmationCode { set; get; }
    }
}
