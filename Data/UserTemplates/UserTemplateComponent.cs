using Core;
using Data.Templates;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.UserTemplates
{
    [Table(TableName.USER_TEMPLATE_COMPONENT, Schema = "dbo")]
    public class UserTemplateComponent : BaseEntity
    {
        [ForeignKey(TableName.TEMPLATE_PROFILE)]
        public int ProfileId { get; set; }
        [ForeignKey(TableName.USER_TEMPLATE_SECTION)]
        public int UserTemplateSectionId { get; set; }
        public string Name { get; set; }
        public string? UniqueTag { get; set; }
        public string? Value { get; set; }
        public bool HasRedirectUrl { get; set; }
        public string? RedirectUrl { get; set; }
        public bool HasSubComponent { get; set; }
        public TemplateProfile? TemplateProfile { get; set; }
        public TemplateSection? TemplateSection { get; set; }
    }
}
