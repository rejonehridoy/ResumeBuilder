

using Core;
using Data.Templates;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.UserTemplates
{
    [Table(TableName.USER_TEMPLATE_SUB_COMPONENT, Schema = "dbo")]
    public class UserTemplateSubComponent : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_PROFILE)]
        public int ProfileId { get; set; }
        public int UserTemplateComponentId { get; set; }
        public string Name { get; set; }
        public string? UniqueTag{ get; set; }
        public string? Value{ get; set; }
        public bool HasKeyValuePair{ get; set; }
        public TemplateProfile? TemplateProfile{ get; set; }
    }
}
