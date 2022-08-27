

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Language
{
    [Table(TableName.LOCAL_STRING_RESOURCE, Schema = "dbo")]
    public class LocaleStringResource : BaseEntity
    {
        [ForeignKey(TableName.LANGUAGE)]
        public int LanguageId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }
        public Language? Language { get; set; }
    }
}
