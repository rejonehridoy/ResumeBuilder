
using Core;
using Data.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Settings
{
    [Table(TableName.USER_SETTINGS, Schema = "dbo")]
    public class UserSetting : BaseEntity
    {
        public string Name { get; set; }
        public string? Value { get; set; }
        [ForeignKey(TableName.USER)]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
