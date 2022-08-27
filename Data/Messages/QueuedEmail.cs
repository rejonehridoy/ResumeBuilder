

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Messages
{
    [Table(TableName.QUEUED_EMAIL, Schema = "dbo")]
    public class QueuedEmail : BaseEntity
    {
        public int Priority { get; set; }
        public string From { get; set; }
        public string FromName { get; set; }
        public string To { get; set; }
        public string ToName { get; set; }
        public string? ReplyTo { get; set; }
        public string? ReplyToName { get; set; }
        public string? CC { get; set; }
        public string? BCC { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public string? AttachmentFilePath { get; set; }
        public string? AttachmentFileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DontSendBeforeDate { get; set; }
        public DateTime? SendDate { get; set; }
        public int SentTries { get; set; }
    }
}
