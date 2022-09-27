using Core;
using Data.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_SECTION, Schema = "dbo")]
    public class TemplateSection : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey(TableName.TEMPLATE)]
        public int TemplateId { get; set; }
        public bool HasComponent { get; set; }
        public bool HasSubComponent { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public int CreatedAdminId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Template? Template { get; set; }
    }
}
