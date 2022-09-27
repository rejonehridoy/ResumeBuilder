

using Core;
using Data.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE, Schema = "dbo")]
    public class Template : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_CATEGORY)]
        public int CategoryId { get; set; }
        public string? TemplateBody { get; set; }
        public string Name { get; set; }
        public bool Published { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DisplayOrder { get; set; }
        [ForeignKey(TableName.USER)]
        public int CreatedAdminId { get; set; }
        public User? User { get; set; }
        public TemplateCategory? TemplateCategory { get; set; }
    }
}
