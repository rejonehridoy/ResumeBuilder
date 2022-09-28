namespace Web.Areas.Admin.Models.Users
{
    public class UserPasswordModel
    {
        public string? Password { get; set; }
        public int PasswordFormatId { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
