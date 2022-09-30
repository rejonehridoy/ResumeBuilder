using Core;
using Data.Files;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Users
{
    [Table(TableName.USER, Schema = "dbo")]
    public class User : BaseEntity
    {
        [Column(TypeName = "nvarchar(400)")]
        public string? Uid { get; set; }
        [Column(TypeName = "nvarchar(400)")]
        public string? Guid { get; set; }
        
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [Column(TypeName = "bit")]
        public bool Active { get; set; }
        [Column(TypeName = "bit")]
        public bool Deleted { get; set; }
        [Column(TypeName = "bit")]
        public bool ExternalLogin { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? LastIpAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public int UserRole { get; set; }
        [ForeignKey(TableName.PICTURE)]
        public int? PictureId { get; set; }
        public Picture? Picture { get; set; }


    }
}
