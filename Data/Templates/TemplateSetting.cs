

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_SETTINGS, Schema = "dbo")]
    public class TemplateSetting : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_PROFILE)]
        public int ProfileId { get; set; }
        public string? Key { get; set; }
        public string Value { get; set; }
        public TemplateProfile? TemplateProfile{ get; set; }
    }
}
