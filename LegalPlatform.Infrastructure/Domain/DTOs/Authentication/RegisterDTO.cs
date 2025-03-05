namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication
{
    public class RegisterDTO
    {
        public string UserName { set; get; }
        public string Password { set; get; }
        public string ConfirmPassword { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
    }   
}
