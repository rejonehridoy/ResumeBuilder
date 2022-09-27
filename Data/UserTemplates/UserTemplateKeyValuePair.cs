
using Core;
using Data.Templates;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.UserTemplates
{
    [Table(TableName.USER_TEMPLATE_KEY_VALUE_PAIR, Schema = "dbo")]
    public class UserTemplateKeyValuePair : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_PROFILE)]
        public int ProfileId { get; set; }
        [ForeignKey(TableName.USER_TEMPLATE_SUB_COMPONENT)]
        public int UserTemplateSubComponent { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public bool Required { get; set; }
        public TemplateProfile? TemplateProfile { get; set; }
        public UserTemplateSubComponent? UserTemplateSubComponents { get; set; }
    }
}
