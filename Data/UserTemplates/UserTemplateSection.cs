using Core;
using Data.Templates;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.UserTemplates
{
    [Table(TableName.USER_TEMPLATE_SECTION, Schema = "dbo")]
    public class UserTemplateSection : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_PROFILE)]
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public bool HasComponent { get; set; }
        public TemplateProfile? TemplateProfile { get; set; }
    }
}
