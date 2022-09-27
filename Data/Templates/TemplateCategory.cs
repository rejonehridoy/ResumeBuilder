using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_CATEGORY, Schema = "dbo")]
    public class TemplateCategory : BaseEntity
    {

        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
    }
}
