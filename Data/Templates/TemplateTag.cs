

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_TAG, Schema = "dbo")]
    public class TemplateTag : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE)]
        public int TemplateId { get; set; }
        public Template? Template { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
