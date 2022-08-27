
using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Users
{
    [Table(TableName.USER_REVIEW, Schema = "dbo")]
    public class UserReview : BaseEntity
    {
        [ForeignKey(TableName.USER)]
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? ReviewText { get; set; }
        public string? ReplyText { get; set; }
        public int? Rating { get; set; }
        public int Approved { get; set; }
        public int TotalLike { get; set; }
        public int TotalDislike { get; set; }
        public DateTime CreatedDate { get; set; }
        public User? User { get; set; }
    }
}
