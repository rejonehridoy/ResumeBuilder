using Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Users
{
    [Table(TableName.USER_PASSWORD, Schema = "dbo")]
    public class UserPassword : BaseEntity
    {
        [Required]
        [ForeignKey(TableName.USER)]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Password { get; set; }
        public int PasswordFormatId { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string PasswordSalt { get; set; }
        public DateTime CreatedDate { get; set; }
        public User? User { get; set; }
    }
}
