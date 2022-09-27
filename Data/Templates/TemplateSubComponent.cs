using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_SUB_COMPONENT, Schema = "dbo")]
    public class TemplateSubComponent : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_COMPONENT)]
        public int TemplateComponentId { get; set; }
        public string? Name { get; set; }
        public string? UniqueTag { get; set; }
        public string? Value { get; set; }
        public bool HasRedirectUrl { get; set; }
        public string? RedirectUrl { get; set; }
        public TemplateComponent? TemplateComponent{ get; set; }
    }
}
