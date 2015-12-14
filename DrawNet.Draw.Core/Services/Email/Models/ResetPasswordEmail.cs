namespace DrawNet.Draw.Core.Services.Email.Models
{
    public class ResetPasswordEmail
    {
        public string FullName { get; set; } 
        public string CompanyName { get; set; }
        public string CompanyImageUrl { get; set; }
        public string PasswordResetUrl { get; set; }
    }
}