namespace GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication
{
    public class RegisterDTO
    {
        public string Role { set; get; }
        public string Email { set; get; }
        public string FullName { set; get; }
        public string Password { set; get; }
        public string PhoneNumber { set; get; }
    }   
}
