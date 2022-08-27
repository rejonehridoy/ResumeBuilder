
using Core;
using Data.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.LogEvents
{
    [Table(TableName.LOG, Schema = "dbo")]
    public class Log : BaseEntity
    {
        public int LogLevel { get; set; }
        [ForeignKey(TableName.USER)]
        public int UserId { get; set; }
        public string? ShortMessage { get; set; }
        public string? FullMessage { get; set; }
        public string? IpAddress { get; set; }
        public string? PageUrl { get; set; }
        public DateTime CreatedDate{ get; set; }
        public User? User { get; set; }

    }
}
