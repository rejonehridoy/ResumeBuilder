

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Templates
{
    [Table(TableName.TEMPLATE_COMPONENT, Schema = "dbo")]
    public class TemplateComponent : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_SECTION)]
        public int TemplateSectionId { get; set; }
        public string Name { get; set; }
        public string? UniqueTag { get; set; }
        public string? Value { get; set; }
        public bool HasRedirectUrl { get; set; }
        public string? RedirectUrl { get; set; }
        public bool HasSubComponenet { get; set; }
        public bool Required { get; set; }
        public TemplateSection? TemplateSection { get; set; }
    }
}
