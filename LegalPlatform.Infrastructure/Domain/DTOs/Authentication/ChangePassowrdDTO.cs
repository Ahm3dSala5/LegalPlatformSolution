namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication
{
    public class ChangePassowrdDTO
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public string ConfirmPassword { set; get; }
    }
}
