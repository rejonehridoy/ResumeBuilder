using Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Data.Language
{
    [Table(TableName.LANGUAGE, Schema = "dbo")]
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? LanguageCulture { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? UniqueSeoCode { get; set; }
        [Column(TypeName = "bit")]
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public string? TimeZone { get; set; }

    }
}
