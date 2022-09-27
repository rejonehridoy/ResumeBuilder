using Core;
using Data.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_PROFILE, Schema = "dbo")]
    public class TemplateProfile : BaseEntity
    {
        public int UserId { get; set; }
        [ForeignKey(TableName.TEMPLATE)]
        public int TemplateId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Template? Template { get; set; }
    }
}
