

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_KEY_VALUE_PAIR, Schema = "dbo")]
    public class TemplateKeyValuePair : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_SUB_COMPONENT)]
        public int TemplateSubComponentId { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public bool Required{ get; set; }
        public bool HasRedirectUrl{ get; set; }
        public string? RedirectUrl{ get; set; }
        public TemplateSubComponent? TemplateSubComponent { get; set; }
    }
}
